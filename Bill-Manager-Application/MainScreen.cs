using System;
using System.Windows.Forms;

namespace Password_Manager_Application
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            CLoadSaveData load = new CLoadSaveData();
            load.OnApplicationLoad();
        }

        private void MainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            CLoadSaveData close = new CLoadSaveData();
            close.OnApplicationClose();
        }
    }
}
