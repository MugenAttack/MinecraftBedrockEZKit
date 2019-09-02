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
using Newtonsoft.Json.Linq;

namespace MinecraftBedrockEZKit
{
    public partial class newProfile : MetroFramework.Forms.MetroForm
    {
        public newProfile()
        {
            InitializeComponent();
        }

        private void NewProfile_Load(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(File.Open("Profiles/" + txtName.Text + ".txt",FileMode.Create)))
            {
                sw.WriteLine(cbVersion.Text);
                sw.WriteLine(txtBehLoc.Text);
                sw.WriteLine(txtResLoc.Text);
                sw.WriteLine(txtNamespace.Text.ToLower());
            }

            //check if proper files are present
            DialogResult dr = DialogResult.Yes;
            if (!Directory.Exists(txtBehLoc.Text + "/items"))
            {
                if (tglMissing.Checked)
                    dr = MetroFramework.MetroMessageBox.Show(this, "Behavior Pack does not contain an items folder would you like to create it?", "Required Folder is Missing!!!", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    Directory.CreateDirectory(txtBehLoc.Text + "/items");
                }
            }

            if (!Directory.Exists(txtResLoc.Text + "/items"))
            {
                if (tglMissing.Checked)
                    dr = MetroFramework.MetroMessageBox.Show(this, "Resource Pack does not contain an items folder would you like to create it?", "Required Folder is Missing!!!", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    Directory.CreateDirectory(txtResLoc.Text + "/items");
                }
            }

            if (!Directory.Exists(txtResLoc.Text + "/textures"))
            {
                if (tglMissing.Checked)
                    dr = MetroFramework.MetroMessageBox.Show(this, "Resource Pack does not contain an items folder would you like to create it?", "Required Folder is Missing!!!", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    Directory.CreateDirectory(txtResLoc.Text + "/textures");
                    if (tglMissing.Checked)
                        dr = MetroFramework.MetroMessageBox.Show(this, "Would like to create the textures/items folder with this folder", "", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                        Directory.CreateDirectory(txtResLoc.Text + "/textures/items");
                    if (tglMissing.Checked)
                        dr = MetroFramework.MetroMessageBox.Show(this, "Would like to create the item_texture.json with this folder", "", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                        createItemTextureJson();
                    
                }
            }

            if (!Directory.Exists(txtResLoc.Text + "/textures/items"))
            {
                if (tglMissing.Checked)
                    dr = MetroFramework.MetroMessageBox.Show(this, "Resource Pack does not contain an textures/items folder would you like to create it?", "Required Folder is Missing!!!", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    Directory.CreateDirectory(txtResLoc.Text + "/textures/items");
                }
            }

            if (!File.Exists(txtResLoc.Text + "/textures/item_texture.json"))
            {
                if (tglMissing.Checked)
                    dr = MetroFramework.MetroMessageBox.Show(this, "Resource Pack does not contain item_texture.json file would you like to create it?", "Required File is Missing!!!", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    createItemTextureJson();
                }
            }

            if (!Directory.Exists(txtResLoc.Text + "/texts"))
            {
                if (tglMissing.Checked)
                    dr = MetroFramework.MetroMessageBox.Show(this, "Resource Pack does not contain an texts folder would you like to create it?", "Required Folder is Missing!!!", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    Directory.CreateDirectory(txtResLoc.Text + "/texts");
                    if (tglMissing.Checked)
                        dr = MetroFramework.MetroMessageBox.Show(this, "Would you like to create the language files for GB and US with this folder", "", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        File.WriteAllText(txtResLoc.Text + "/texts/en_GB.lang", "");
                        File.WriteAllText(txtResLoc.Text + "/texts/en_US.lang", "");
                    }
                }
            }
            this.Close();
        }

        private void createItemTextureJson()
        {
            JObject itemtex = new JObject
            {
                {"resource_pack_name", txtName.Text },
                {"texture_name", "atlas.items" },
                {"texture_data", new JObject{ } }
            };
            File.WriteAllText(txtResLoc.Text + "/textures/item_texture.json", itemtex.ToString());
        }
    }
}
