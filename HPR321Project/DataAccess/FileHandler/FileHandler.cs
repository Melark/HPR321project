using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataAccess.FileHandler
{
    public class FileHandler : IDisposable
    {
        #region Fields

        string filePath;
        StreamReader reader;
        StreamWriter writer;

        #endregion

        #region Constructor

        public FileHandler(string FilePathParam)
        {
            this.filePath = FilePathParam;
        }

        #endregion

        #region Properties

        #endregion

        #region Methods

        #region Read Data

        public string[] Read()
        {
            return Read(filePath);
        }

        public string[] Read(string FilePathToRead)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Write Data

        #region Append

        #endregion

        #region Overwrite

        #endregion

        #endregion

        #region Clear File



        #endregion

        #region Creation

        private void CreateFile()
        {

        }

        #endregion

        #region Test

        /// <summary>
        /// Test the connection to the file
        /// </summary>
        /// <param name="FilePathParam">File Path to test</param>
        /// <param name="ReadingFile">True if the user is trying to read the file, false if the user is trying to write to the file</param>
        /// <returns>If the connection was successful</returns>
        private bool Test(string FilePathParam, bool ReadingFile)
        {
            try
            {
                if (ReadingFile)
                {
                    reader = null;
                    reader = new StreamReader(new FileStream(FilePathParam, FileMode.Open, FileAccess.Read));
                    reader.Close();

                    return true;
                }
                else
                {
                    writer = null;
                    writer = new StreamWriter(new FileStream(FilePathParam, FileMode.Open, FileAccess.Write));
                    writer.Close();

                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region Interface Implementation

        public void Dispose()
        {
            try
            {
                reader.Close();
                reader = null;
            } catch (Exception){ }

            try
            {
                writer.Close();
                writer = null;
            }
            catch (Exception) { }

            filePath = null;
        }

        #endregion

        #endregion
    }
}
