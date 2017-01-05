using System;

namespace Password_Manager_Application
{
    public static class Constants
    {
        #region Fields

        private static readonly string docName = @"\UserData.bin";
        private static readonly string docPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private static readonly string fileName;
        #endregion

        #region Constructors

        static Constants()
        {
            fileName = docPath + docName;
        }
        #endregion

        #region Properties

        public static string FileName { get { return fileName; } }
        #endregion
    }
}
