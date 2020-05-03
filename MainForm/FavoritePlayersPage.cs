using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Model;
using DAL;

namespace MainForm
{
    public partial class FavoritePlayersPage : Form
    {
        private const string URL = @"https://world-cup-json-2018.herokuapp.com/matches/country?fifa_code=";
        private string FIFACODE;
        public FavoritePlayersPage(string fifaCode)
        {
            InitializeComponent();
            FormSetup.Setup();
            StartPosition = FormStartPosition.CenterScreen;
            FIFACODE = fifaCode;
            Setup();
        }

        private void Setup()
        {
            string[] config = FormSetup.Load();
            Debug.WriteLine(config.Length);
            if(config.Length == 1)
            {
                StartPage form = new StartPage();
                form.ShowDialog();
                form.BringToFront();
                Hide();
            }
            else if(config.Length == 2)
            {
                FavoriteRepresentationPage form = new FavoriteRepresentationPage();
                form.ShowDialog();
                form.BringToFront();
                Hide();
            }
            else
            {
                FIFACODE = config[2];
                Debug.WriteLine(URL + FIFACODE);
                //lbTest.Text = Repository.GetStartingEleven(URL + FIFACODE);
            }
        }
    }
}
