using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Globalization;

namespace x_BIMU_Terminal
{
    /// <summary>
    /// CSV file writer class to handle writing of x-BIMU packets to file.
    /// </summary>
    class CsvFileWriter
    {
        /// <summary>
        /// File indexes of streamWriters array.  Labels will be used to extend corresponding CSV file name.
        /// </summary>
        private enum FileIndexes
        {
            Quaternion,
            Sensor,
            Battery,
            NumberOfFiles
        }

        /// <summary>
        /// Column headings to appear as first line of each CSV file.
        /// </summary>
        private string[] columnHeadings;

        /// <summary>
        /// File path of CSV files.  Actual file name will be extended with label of packet type.
        /// </summary>
        private string filePath;

        /// <summary>
        /// Write enabled flag to avoid asynchronous issues.
        /// </summary>
        private bool writesEnabled;

        /// <summary>
        /// Array of StreamWriters for each CSV file.
        /// </summary>
        private StreamWriter[] streamWriters;

        /// <summary>
        /// Start time of logging used to calculate time stamp.
        /// </summary>
        private DateTime startDateTime;

        /// <summary>
        /// Constructor called at start of logging.
        /// </summary>
        /// <param name="filePath">
        /// File path of CSV files.  Actual file name will be extended with label of packet type.
        /// </param>
        public CsvFileWriter(string filePath)
        {
            columnHeadings = new string[] { "time (ms),w (10000),x (10000),y (10000),z (10000),packet counter",
                                            "time (ms),gyroscope x (0.1 deg/s),gyroscope y (0.1 deg/s),gyroscope z (0.1 deg/s),accelerometer x (mg),accelerometer y (mg),accelerometer z (mg),magnetometer x (mG),magnetometer y (mG),magnetometer z (mG),packet counter",
                                            "time (ms),battery voltage (mV),packet counter" };
            this.filePath = filePath;
            writesEnabled = true;
            streamWriters = new StreamWriter[(int)FileIndexes.NumberOfFiles];
            startDateTime = DateTime.MinValue;
        }

        /// <summary>
        /// Close all CSV files.
        /// </summary>
        public void CloseFiles()
        {
            writesEnabled = false;
            for (int i = 0; i < (int)FileIndexes.NumberOfFiles; i++)
            {
                if (streamWriters[i] != null)
                {
                    streamWriters[i].Close();
                    streamWriters[i] = null;
                }
            }
        }

        /// <summary>
        /// Get current time elapsed since first packet logged.
        /// </summary>
        /// <returns>
        /// Time elapsed since first packet logged.
        /// </returns>
        public TimeSpan GetTime()
        {
            if (startDateTime == DateTime.MinValue)
            {
                return TimeSpan.Zero;
            }
            else
            {
                return DateTime.Now - startDateTime;
            }
        }

        /// <summary>
        /// Write quaternion data to CSV file.
        /// </summary>
        /// <param name="w">
        /// Quaternion w component.
        /// </param>
        /// <param name="x">
        /// Quaternion x component.
        /// </param>
        /// <param name="y">
        /// Quaternion y component.
        /// </param>
        /// <param name="z">
        /// Quaternion w component.
        /// </param>
        /// <param name="counter">
        /// Packet counter.
        /// </param>
        public void WriteQuaternionData(int w, int x, int y, int z, int counter)
        {
            WriteCsvLine(new float[] { (float)w, (float)x, (float)y, (float)z, (float)counter }, FileIndexes.Quaternion);
        }

        /// <summary>
        /// Write sensor data to CSV file.
        /// </summary>
        /// <param name="gx">
        /// Gyroscope x axis value.
        /// </param>
        /// <param name="gy">
        /// Gyroscope y axis value.
        /// </param>
        /// <param name="gz">
        /// Gyroscope z axis value.
        /// </param>
        /// <param name="ax">
        /// Accelerometer x axis.
        /// </param>
        /// <param name="ay">
        /// Accelerometer y axis.
        /// </param>
        /// <param name="az">
        /// Accelerometer z axis.
        /// </param>
        /// <param name="mx">
        /// Magnetometer x axis.
        /// </param>
        /// <param name="my">
        /// Magnetometer y axis.
        /// </param>
        /// <param name="mz">
        /// Magnetometer z axis.
        /// </param>
        /// <param name="counter">
        /// Packet counter.
        /// </param>
        public void WriteSensorData(int gx, int gy, int gz, int ax, int ay, int az, int mx, int my, int mz, int counter)
        {
            WriteCsvLine(new float[] { (float)gx, (float)gy, (float)gz, (float)ax, (float)ay, (float)az, (float)mx, (float)my, (float)mz, (float)counter }, FileIndexes.Sensor);
        }

        /// <summary>
        /// Write battery data to CSV file.
        /// </summary>
        /// <param name="b">
        /// Battery value
        /// </param>
        /// <param name="counter">
        /// Packet counter.
        /// </param>
        public void WriteBatteryData(int b, int counter)
        {
            WriteCsvLine(new float[] { (float)b, (float)counter }, FileIndexes.Battery);
        }

        /// <summary>
        /// Write array of floats as CSV file for given file index.
        /// </summary>
        /// <param name="values">
        /// Array of floats to be written as CSVs.
        /// </param>
        /// <param name="fileIndex">
        /// FIle index to be written to.
        /// </param>
        private void WriteCsvLine(float[] values, FileIndexes fileIndex)
        {
            if (writesEnabled)
            {
                // Set start time
                if (startDateTime == DateTime.MinValue)
                {
                    startDateTime = DateTime.Now;
                }

                // Open file
                if (streamWriters[(int)fileIndex] == null)
                {
                    streamWriters[(int)fileIndex] = new System.IO.StreamWriter(filePath + "_" + fileIndex.ToString() + ".csv", false);
                    streamWriters[(int)fileIndex].WriteLine(columnHeadings[(int)fileIndex]);
                }

                // Write line
                string csvLine = "";
                TimeSpan timeSpan = DateTime.Now - startDateTime;
                csvLine += (timeSpan.Days * 24 * 60 * 60 * 1000 +
                            timeSpan.Hours * 60 * 60 * 1000 +
                            timeSpan.Minutes * 60 * 1000 +
                            timeSpan.Seconds * 1000 +
                            timeSpan.Milliseconds).ToString() + ",";
                for (int i = 0; i < values.Length; i++)
                {
                    csvLine += values[i].ToString(CultureInfo.InvariantCulture);
                    if (i < values.Length - 1)
                    {
                        csvLine += ",";
                    }
                }
                streamWriters[(int)fileIndex].WriteLine(csvLine);
            }
        }
    }
}
