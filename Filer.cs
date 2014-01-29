using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO; // Directory, StreamWriter

namespace XFiles
{
    /// <summary>
    /// Class for performing basic file creation and deletion operations
    /// </summary>
    class Filer
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public Filer()
        { }

        /// <summary>
        /// Deletes any directory located at path and creates a new directory in its
        /// place. True has been returned if successful, false if not.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public bool CreateCleanDir(string path)
        {
            // Delete directory if it exists
            if (Directory.Exists(path))
                Directory.Delete(path, true);

            Directory.CreateDirectory(path);
            return true;
        } // CreateCleanDir

        /// <summary>
        /// Creates a text file containing text at directory path. True has been
        /// returned if successful, false if not.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        public bool CreateFile(string text, string path, string name)
        {
            // Check if directory exists
            if (!Directory.Exists(path))
                CreateDir(path);
            //throw new Exception("Directory does not exist");

            StreamWriter sw = new StreamWriter(path + "\\" + name);

            // Write out to file
            try
            { sw.Write(text); }
            catch (Exception e)
            {
                // error
            }

            sw.Close();

            return true;
        } // CreateFile

        /// <summary>
        /// Creates a new directory at path. True has been
        /// returned if successful, false if not.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        public bool CreateDir(string path)
        {
            // Check if directory exists
            // if (!Directory.Exists(path))
            //throw new Exception("Directory does not exist");

            // Write out to file
            try
            { Directory.CreateDirectory(path); }
            catch (Exception e)
            {
                // error
            }

            return true;
        } // CreateFile

		/// <summary>
		/// Opens file at path and returns contents as string
		/// </summary>
		/// <returns>The to string.</returns>
		/// <param name="path">Path.</param>
		public string FileToString(string path){
			try{

				StreamReader sr = new StreamReader(path);
				return sr.ReadToEnd();
			}
			catch(Exception e){
				throw e;
			}
		}

    } // Filer class
} // Namespace
