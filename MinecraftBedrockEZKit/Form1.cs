using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MinecraftBedrockEZKit
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        profileData pd = new profileData();
        public Form1()
        {
            InitializeComponent();
            updateProfileList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Items
        private void MetroTile1_Click(object sender, EventArgs e)
        {
            if (cbProfiles.SelectedIndex >= 0)
            {
                this.Hide();
                items nItem = new items();
                nItem.pd = pd;
                nItem.ShowDialog(this);
                this.Show();
            }
            else
                lblProfileError.Visible = true;
        }

        //Recipes
        private void MetroTile3_Click(object sender, EventArgs e)
        {

        }

        private void BtnProfile_Click(object sender, EventArgs e)
        {
            newProfile np = new newProfile();
            np.ShowDialog();
            updateProfileList();
        }

        private void updateProfileList()
        {
            DirectoryInfo direct = new DirectoryInfo("Profiles");
            FileInfo[] files = direct.GetFiles();
            cbProfiles.Items.Clear();
            foreach (FileInfo f in files)
            {
                cbProfiles.Items.Add(f.Name.Split(".".ToCharArray())[0]);
            }
        }

        private void CbProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblProfileError.Visible = false;
            string[] data = File.ReadAllLines("Profiles/" + cbProfiles.Text + ".txt");
            pd._version = data[0];
            pd._behaviorPack = data[1];
            pd._resourcePack = data[2];
            pd._namespace = data[3];
        }
    }
}
