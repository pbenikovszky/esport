using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using CocNET;
using CocNET.Interfaces;

namespace CocAPITest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            string token =
                "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzUxMiIsImtpZCI6IjI4YTMxOGY3LTAwMDAtYTFlYi03ZmExLTJjNzQzM2M2Y2NhNSJ9.eyJpc3MiOiJzdXBlcmNlbGwiLCJhdWQiOiJzdXBlcmNlbGw6Z2FtZWFwaSIsImp0aSI6IjMwMzc4M2ViLWIyNWYtNDU5MC05M2NmLTFhNmZjMzQ5Yjk1OSIsImlhdCI6MTU5MTMxNTIyMCwic3ViIjoiZGV2ZWxvcGVyLzcyODgzMmI1LTI4NzgtYTJlZi01MTQ0LTUyNTM5N2U3YzI4NiIsInNjb3BlcyI6WyJjbGFzaCJdLCJsaW1pdHMiOlt7InRpZXIiOiJkZXZlbG9wZXIvc2lsdmVyIiwidHlwZSI6InRocm90dGxpbmcifSx7ImNpZHJzIjpbIjk0LjIxLjM0LjEwOSJdLCJ0eXBlIjoiY2xpZW50In1dfQ.OgBZEinxO9LZ51E8mgPZKT_UiWsNt6IvZgr-1wNfZZINkv-vQvtN6vNFaTHXIecCao5RwAh3QHOAWjQS_fhulg";

            Funq.Container container = CocCore.Instance(token).Container;
            ICocCoreClans clansCore = container.Resolve<ICocCoreClans>();

            var clan = clansCore.GetClans(txtTag.Text);

            txtName.Text = clan.Name;
            txtLocation.Text = clan.Location.Name;
            txtType.Text = clan.Type;
            txtClanLevel.Text = clan.ClanLevel.ToString();
            txtClanPoints.Text = clan.ClanPoints.ToString();
            txtWarWins.Text = clan.WarWins.ToString();


        }

        private void txtTag_TextChanged(object sender, EventArgs e)
        {
            btnGetData.Enabled = !String.IsNullOrEmpty(txtTag.Text);
        }
    }
}
