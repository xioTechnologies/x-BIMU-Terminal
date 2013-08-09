using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace x_BIMU_Terminal
{
    /// <summary>
    /// x-BIMU serial decoder. Decodes ASCII and binary packets within serial data stream.
    /// </summary>
    public class SerialDecoder
    {
        /// <summary>
        /// Process new byte in data stream to decode ASCII and binary packets and detect the OK string.
        /// </summary>
        /// <param name="newByte">
        /// Newest byte received within data stream.
        /// </param>
        public void ProcessNewByte(byte newByte)
        {
            DecodeASCII((char)newByte);
            DecodeBinary(newByte);
            DetectOK(newByte);
        }

        #region OK string detection

        /// <summary>
        /// Buffer for detecting "OK\r".
        /// </summary>
        private byte[] okBuf = new byte[256];

        /// <summary>
        /// Buffer index for detecting "OK\r".
        /// </summary>
        private byte okBufIndex = 0;

        /// <summary>
        /// Detect "OK/r" in data stream.
        /// </summary>
        /// <param name="newByte">
        /// Newest byte received within data stream.
        /// </param>
        private void DetectOK(byte newByte)
        {
            okBuf[okBufIndex++] = newByte;
            if (okBuf[(byte)(okBufIndex - 3)] == 'O' &&
                okBuf[(byte)(okBufIndex - 2)] == 'K' &&
                okBuf[(byte)(okBufIndex - 1)] == '\r')
            {
                OnOKReceived();
            }
        }

        #endregion

        #region ASCII packet decoding

        /// <summary>
        /// Buffer used for decoding ASCII packets.
        /// </summary>
        private string asciiBuf = "";

        /// <summary>
        /// Decodes ASCII packets within data stream.
        /// </summary>
        /// <param name="newByte">
        /// Newest byte received within data stream.
        /// </param>
        private void DecodeASCII(char newChar)
        {
            if (newChar == '\r')
            {
                try
                {
                    // Split string to comma separated variables
                    string[] vars = asciiBuf.Split(',');

                    // Validate cheksum (http://en.wikipedia.org/wiki/Longitudinal_redundancy_check)
                    byte checksum = 0;
                    for (int i = 0; i <= asciiBuf.LastIndexOf(','); i++)    // checksum does not include checksum characters
                    {
                        checksum ^= (byte)asciiBuf[i];
                    }
                    if (checksum != byte.Parse(vars[vars.Length - 1]))
                    {
                        throw new Exception();  // checksum failed
                    }

                    // Decode according to packet header
                    switch (vars[0])
                    {
                        case ("Q"):
                            OnQuaternionReceived(new int[] { Int32.Parse(vars[1]), Int32.Parse(vars[2]), Int32.Parse(vars[3]), Int32.Parse(vars[4]),    /* quaternion elements 0, 1, 2, 3   */
                                                             Int32.Parse(vars[5]) });                                                                   /* counter                          */
                            break;
                        case ("S"):
                            OnSensorsReceived(new int[] { Int32.Parse(vars[1]), Int32.Parse(vars[2]), Int32.Parse(vars[3]), /* gyroscope, X, Y, Z axes      */
                                                          Int32.Parse(vars[4]), Int32.Parse(vars[5]), Int32.Parse(vars[6]), /* acceleroemter, X, Y, Z axes  */
                                                          Int32.Parse(vars[7]), Int32.Parse(vars[8]), Int32.Parse(vars[9]), /* magnetometer, X, Y, Z axes   */
                                                          Int32.Parse(vars[10]) });                                         /* counter                      */
                            break;
                        case ("B"):
                            OnBatteryReceived(new int[] { Int32.Parse(vars[1]),     /* battery volatage */
                                                          Int32.Parse(vars[2]) });  /* counter          */
                            break;
                        default:
                            throw new Exception();
                    }
                }
                catch { }
                asciiBuf = "";
            }
            else
            {
                asciiBuf += newChar;
            }
        }

        #endregion

        #region Binary packet decoding

        /// <summary>
        /// Length of each binary packet type.
        /// </summary>
        private enum PacketLengths
        {
            Quaterion = 11,
            Sensor = 21,
            Battery = 5,
            Max = 21    /* maximum packet length of all packet types */
        }

        /// <summary>
        /// Buffer used for decoding binary packets.
        /// </summary>
        private byte[] binBuf = new byte[256];

        /// <summary>
        /// Buffer index for decoding binary packets.
        /// </summary>
        private byte binBufIndex = 0;

        /// <summary>
        /// Flag indicating is binary decoding is in sync.
        /// </summary>
        private bool inSync = false;

        /// <summary>
        /// Number of bytes received since assumed header byte.
        /// </summary>
        private int byteCount = 0;

        /// <summary>
        /// Decodes data packets within data stream.
        /// </summary>
        /// <param name="newByte">
        /// Newest byte received within data stream.
        /// </param>
        private void DecodeBinary(byte newByte)
        {
            // Add new byte to buffer
            binBuf[binBufIndex++] = newByte;

            // Check if out of sync
            byteCount++;
            if (byteCount > (int)PacketLengths.Max)
            {
                byteCount = (int)PacketLengths.Max; // prevent overflow
                inSync = false;
            }

            // Decode quaternion packet
            if (binBufIndex >= (byte)PacketLengths.Quaterion)
            {
                if ((inSync ? (char)binBuf[0] : (char)binBuf[binBufIndex - (byte)PacketLengths.Quaterion]) == 'Q')
                {
                    if (CalcChecksum((byte)PacketLengths.Quaterion) == 0)
                    {
                        OnQuaternionReceived(new int[] { (short)((binBuf[binBufIndex - 10] << 8) | binBuf[binBufIndex - 9]),    /* quatenrion element 0 */
                                                         (short)((binBuf[binBufIndex - 8] << 8) | binBuf[binBufIndex - 7]),     /* quatenrion element 1 */
                                                         (short)((binBuf[binBufIndex - 6] << 8) | binBuf[binBufIndex - 5]),     /* quatenrion element 2 */
                                                         (short)((binBuf[binBufIndex - 4] << 8) | binBuf[binBufIndex - 3]),     /* quatenrion element 3 */
                                                         binBuf[binBufIndex - 2] });                                            /* counter              */
                        binBufIndex = 0;
                        byteCount = 0;
                        inSync = true;
                    }
                }
            }

            // Decode sensor packet
            if (binBufIndex >= (byte)PacketLengths.Sensor)
            {
                if ((inSync ? (char)binBuf[0] : (char)binBuf[binBufIndex - (byte)PacketLengths.Sensor]) == 'S')
                {
                    if (CalcChecksum((byte)PacketLengths.Sensor) == 0)
                    {
                        OnSensorsReceived(new int[] { (short)((binBuf[binBufIndex - 20] << 8) | binBuf[binBufIndex - 19]),  /* gyroscope X axis     */
                                                      (short)((binBuf[binBufIndex - 18] << 8) | binBuf[binBufIndex - 17]),  /* gyroscope Y axis     */
                                                      (short)((binBuf[binBufIndex - 16] << 8) | binBuf[binBufIndex - 15]),  /* gyroscope Z axis     */
                                                      (short)((binBuf[binBufIndex - 14] << 8) | binBuf[binBufIndex - 13]),  /* accelerometer X axis */
                                                      (short)((binBuf[binBufIndex - 12] << 8) | binBuf[binBufIndex - 11]),  /* accelerometer Y axis */
                                                      (short)((binBuf[binBufIndex - 10] << 8) | binBuf[binBufIndex - 9 ]),  /* accelerometer Z axis */
                                                      (short)((binBuf[binBufIndex - 8] << 8) | binBuf[binBufIndex - 7 ]),   /* magnetometer X axis  */
                                                      (short)((binBuf[binBufIndex - 6] << 8) | binBuf[binBufIndex - 5 ]),   /* magnetometer Y axis  */
                                                      (short)((binBuf[binBufIndex - 4] << 8) | binBuf[binBufIndex - 3 ]),   /* magnetometer Z axis  */
                                                      binBuf[binBufIndex - 2] });                                           /* counter              */
                        binBufIndex = 0;
                        byteCount = 0;
                        inSync = true;
                    }
                }
            }

            // Decode battery packet
            if (binBufIndex >= (byte)PacketLengths.Battery)
            {
                if ((inSync ? (char)binBuf[0] : (char)binBuf[binBufIndex - (byte)PacketLengths.Battery]) == 'B')
                {
                    if (CalcChecksum((byte)PacketLengths.Battery) == 0)
                    {
                        OnBatteryReceived(new int[] { (short)((binBuf[binBufIndex - 4] << 8) | binBuf[binBufIndex - 3]) ,   /* battery voltage  */
                                                      binBuf[binBufIndex - 2] });                                           /* counter          */
                        binBufIndex = 0;
                        byteCount = 0;
                        inSync = true;
                    }
                }
            }
        }

        /// <summary>
        /// Calculate LRC checksum.
        /// </summary>
        /// <param name="packetLength">
        /// Length of packet including checksum.
        /// </param>
        /// <returns>
        /// Zero if checksum passed.
        /// </returns>
        /// <remarks>
        /// http://en.wikipedia.org/wiki/Longitudinal_redundancy_check
        /// </remarks>
        private byte CalcChecksum(byte packetLength)
        {
            byte tempRxBufIndex = (byte)(binBufIndex - packetLength);
            byte checksum = 0;
            while (tempRxBufIndex != binBufIndex)
            {
                checksum ^= binBuf[tempRxBufIndex++];
            }
            return checksum;
        }

        #endregion

        public delegate void onOKReceived();
        public event onOKReceived OKReceived;
        protected virtual void OnOKReceived() { if (OKReceived != null) OKReceived(); }

        public delegate void onQuaternionReceived(int[] i);
        public event onQuaternionReceived QuaternionReceived;
        protected virtual void OnQuaternionReceived(int[] i) { if (QuaternionReceived != null) QuaternionReceived(i); }

        public delegate void onSensorsReceived(int[] i);
        public event onSensorsReceived SensorsReceived;
        protected virtual void OnSensorsReceived(int[] i) { if (SensorsReceived != null) SensorsReceived(i); }

        public delegate void onThermometerReceived(int[] i);
        public event onThermometerReceived ThermometerReceived;
        protected virtual void OnThermometerReceived(int[] i) { if (ThermometerReceived != null) ThermometerReceived(i); }

        public delegate void onBatteryReceived(int[] i);
        public event onBatteryReceived BatteryReceived;
        protected virtual void OnBatteryReceived(int[] i) { if (BatteryReceived != null) BatteryReceived(i); }
    }
}