using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace user
{
    public partial class MobAmp : Form
    {
        public void addDevice()
        {
            string partition = Environment.GetFolderPath(Environment.SpecialFolder.System); //znajduje partycję sytemową
            string path = partition + "\\DevicePairingWizard.exe";
            try
            {  
                Process p = Process.Start(path); //uruchamia okno do dodawania urządzeń
                while (true)
                {
                    if (p.HasExited) //determine if process end
                        break;
                }                
            }
            catch (Exception ex)
            {
                if (DialogResult.Retry == MessageBox.Show(ex.ToString(), "Nie można odnaleźć dodanego przez ciebie urządzenia", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error))
                    addDevice();                
            }
        }
        public MobAmp()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
           addDevice();
        }

       

       
    }
}
