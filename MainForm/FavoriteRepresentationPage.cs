using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Model;
using DAL;
using System.Diagnostics;

namespace MainForm
{
    public partial class FavoriteRepresentationPage : Form
    {
        private const string MEN = "https://world-cup-json-2018.herokuapp.com/teams/results";
        private const string WOMEN = "https://worldcup.sfg.io/teams/results";
        private string[] config = FormSetup.Load();

        public FavoriteRepresentationPage()
        {
            InitializeComponent();
            SetupComboBox();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void SetupComboBox()
        {
            string[] config = FormSetup.Load();
            cbRepresentations.IntegralHeight = false;
            cbRepresentations.MaxDropDownItems = 7;
            if(config[1] == "MEN")
            {
                foreach(var rep in Repository.GetRepresentations(MEN).representations)
                {
                    cbRepresentations.Items.Add(rep.FIFA_Code);
                }
            }
            else if (config[1] == "WOMEN")
            {
                foreach (var rep in Repository.GetRepresentations(WOMEN).representations)
                {
                    cbRepresentations.Items.Add(rep.FIFA_Code);
                }
            }
        }

        private void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            FormSetup.Save(config[0], config[1], cbRepresentations.SelectedItem.ToString());
            var form = new FavoritePlayersPage(cbRepresentations.SelectedItem.ToString());
            form.ShowDialog();
            Close();
        }
    }
}
