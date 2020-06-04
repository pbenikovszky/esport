using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using MingweiSamuel.Camille;
using MingweiSamuel.Camille.Enums;

namespace RiotCocAPITest
{
    public partial class Form1 : Form
    {

        private const string API_KEY = "RGAPI-f4d3dccb-3086-48f2-b939-db4fc8047887";

        public Form1()
        {
            InitializeComponent();
        }



        private void btnGetData_Click(object sender, EventArgs e)
        {

            dgvChampions.Rows.Clear();
            dgvChampions.Refresh();                

            StringBuilder sb = new StringBuilder();
            RiotApi riotApi = RiotApi.NewInstance(API_KEY);
            var region = MingweiSamuel.Camille.Enums.Region.EUNE;
            var summoner = riotApi.SummonerV4.GetBySummonerName(region, txtSummonerName.Text);

            if (summoner == null)
            {
                MessageBox.Show("Summoner cannot be found!");
                return;
            }

            sb.AppendLine($"{summoner.Name} Top 10 bajnoka");
            sb.AppendLine();

            var masteries = riotApi.ChampionMasteryV4.GetAllChampionMasteries(region, summoner.Id);

            int maxChamps = masteries.Length > 10 ? 10 : masteries.Length;
            
            for (int i = 0; i < maxChamps; i++)
            {
                var mastery = masteries[i];
                var champ = (Champion)mastery.ChampionId;
                dgvChampions.Rows.Add((i + 1).ToString(), champ.Name(), mastery.ChampionPoints, mastery.ChampionLevel);
            }

        }

        private void txtSummonerName_TextChanged(object sender, EventArgs e)
        {
            btnGetData.Enabled = !String.IsNullOrEmpty(txtSummonerName.Text);
        }
    }
}
