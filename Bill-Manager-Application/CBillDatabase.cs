using System;
using System.Collections.Generic;

namespace Password_Manager_Application
{

    // This class stores all of the users saved bills in a list
    class CBillDatabase
    {
        #region Fields

        private static CBillDatabase sharedInstance;
        private List<CBill> database;

        #endregion "Fields"





        #region Constructors

        private CBillDatabase() {}

        #endregion "Constructors"




        #region Properties

        public static CBillDatabase SharedInstance
        {
            get
            {
                if (sharedInstance == null)
                    sharedInstance = new CBillDatabase();
                return sharedInstance;
            }
        }

        public List<CBill> Database
        {
            get
            {
                return database;
            }
            set
            {
                if (database == null)
                {
                    database = new List<CBill>();
                }
                database = value;
            }
        }

        #endregion "Properties"




        #region Methods

        public void AddBill()
        {

        }

        public void DeleteBill()
        {

        }

        //public CBill FindBill(string name)
        //{

        //}

        #endregion "Methods"
    }
}
