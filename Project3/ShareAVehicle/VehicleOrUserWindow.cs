using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShareAVehicle
{
    public partial class VehicleOrUserWindow : Form
    {
        public VehicleOrUserWindow()
        {
            InitializeComponent();
        }

        private void UserBtn_Click(object sender, EventArgs e)
        {
            MainWindow main = new MainWindow(true);
            main.Show();
        }

        private void DriverBtn_Click(object sender, EventArgs e)
        {
            MainWindow main = new MainWindow(false);
            main.Show();
        }
    }
}
