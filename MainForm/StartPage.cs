using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Model;

namespace MainForm
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
            FormSetup.Setup();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnMen_Click(object sender, EventArgs e)
        {
            FormSetup.Save(GetLocalization(), "MEN");
            var form = new FavoriteRepresentationPage();
            form.ShowDialog();
            form.BringToFront();
            Hide();
        }

        private void btnWomen_Click(object sender, EventArgs e)
        {
            FormSetup.Save(GetLocalization(), "WOMEN");
            var form = new FavoriteRepresentationPage();
            form.ShowDialog();
            form.BringToFront();
            Hide();
        }

        private string GetLocalization()
        {
            if (rbtnHR.Checked)
                return "HR";
            else if (rbtnEN.Checked)
                return "EN";
            return "HR";
        }
    }
}
