using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinecraftBedrockEZKit
{
    public partial class items : MetroFramework.Forms.MetroForm
    {
        public profileData pd;
        MCItem item= new MCItem();
        public items()
        {
            InitializeComponent();
        }

        private void Items_Load(object sender, EventArgs e)
        {
            item.iComponents.Add(new maxStack());
            updateComponents();
        }

        private void PictImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                item.img = Image.FromFile(ofd.FileName);
                pictImage.Image = item.img;
            }
        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstComponents.SelectedIndices[0] >= 0)
                {
                    item.iComponents[lstComponents.SelectedIndices[0]].editComponent();
                    updateComponents();
                }
            }
            catch
            {

            }
        }
        private void updateComponents()
        {
            lstComponents.Items.Clear();
            foreach (ItemComponents ic in item.iComponents)
            {
                lstComponents.Items.Add(ic.getViewInfo());
            }
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            item.name = txtName.Text;
        }

        private void TxtDName_TextChanged(object sender, EventArgs e)
        {
            item.displayName = txtDName.Text;
        }

        private void CbCategory_TextChanged(object sender, EventArgs e)
        {
            item.category = cbCategory.Text;
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            item.create(pd);
        }
    }
}
