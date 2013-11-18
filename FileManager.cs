using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XFiles
{
    /// <summary>
    /// Singleton Class wrapping the functionality to load and save files
    /// </summary>
    class FileManager
    {
        // Static instance of class
        private static FileManager c_fmInstance;

        // Lock object
        private static object c_fmLock = new Object();

        // Program name 
        private string m_sProgramName = "XFiles";
        // Version
        private string m_sVer = "1.00";

        private Filer m_filer = new Filer();

        // Default paths and filenames
        private string m_sLastFilePath = "C:\\";
        private string m_sLastFileName = "";

        // SourceReader object
        private SourceReader m_SrcRdr = SourceReader.Instance;

        /// <summary>
        /// Default constructor 
        /// </summary>
        private FileManager() { }

        /// <summary>
        /// Return static instance of class
        /// </summary>
        public static FileManager Instance
        {
            get
            {
                lock (c_fmLock)
                {
                    if (c_fmInstance == null)
                        c_fmInstance = new FileManager();
                    return c_fmInstance;
                } // lock
            } // get
        } // Instance

        /// <summary>
        /// Returns the compiler's name
        /// </summary>
        public string ProgramName
        { get { return m_sProgramName; } }

        /// <summary>
        /// Returns the compiler's current version
        /// </summary>
        public string ProgramVersion
        { get { return m_sVer; } }

        /// <summary>
        /// Get/set last path of file opened
        /// </summary>
        public string LastFilePath
        {
            get { return m_sLastFilePath; }
            set { m_sLastFilePath = value; }
        } // LastFilePath

        /// <summary>
        /// Get/set name of last opened file without extension
        /// </summary>
        public string LastFileName
        {
            // Remove .mod
            get { return m_sLastFileName.Remove(m_sLastFileName.Length - 4, 4); }
            set { m_sLastFileName = value; }
        } // LastFileName

        /// <summary>
        /// Opens the file specified at path. True is returned if successful, else
        /// false has been returned
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public bool OpenFile(string path)
        { return m_SrcRdr.OpenFile(path); }

        /// <summary>
        /// Deletes any directory located at path. True has been returned if 
        /// successful, false if not.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public bool CreateCleanDirectory(string path)
        { return m_filer.CreateCleanDir(path); }

        /// <summary>
        /// Creates a text file containing text at directory path. True has been
        /// returned if successful, false if not.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        public bool CreateFile(string text, string path, string name)
        { return m_filer.CreateFile(text, path, name); }

        /// <summary>
        /// Creates a new directory at path. True has been returned if successful,
        /// false if not
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public bool CreateDir(string path)
        { return m_filer.CreateDir(path); }

        /// <summary>
        /// Returns true if there is a file open, false if not
        /// </summary>
        /// <returns></returns>
        public bool isOpen()
        { return m_SrcRdr.isOpen(); }

        /// <summary>
        /// Closes the active file. True is returned if successful, else
        /// false has been returned
        /// </summary>
        /// <returns></returns>
        public bool CloseFile()
        { return m_SrcRdr.CloseFile(); }

        /// <summary>
        /// Resets current char and line count in source file
        /// </summary>
        public void Reset()
        { m_SrcRdr.Reset(); }

        /// <summary>
        /// Returns the contents of the active file in string form
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        { return m_SrcRdr.FileToString; }

        /// <summary>
        /// Returns the active files full name and path
        /// </summary>
        public string CurrentFileName
        { get { return m_SrcRdr.FileName; } }

    } // Class FileManager
} // Namespace XFiles