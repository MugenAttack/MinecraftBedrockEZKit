using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace MinecraftBedrockEZKit
{
    class ItemComponents
    {
        public virtual JObject getJSON()
        {
            return new JObject();
        }

        public virtual ListViewItem getViewInfo()
        {
            return new ListViewItem(new string[]{"Component","0" });
        }

        public virtual void editComponent()
        {

        }
    }

    class maxStack : ItemComponents
    {
        int Size = 1;
        
        public override JObject getJSON()
        {
            return new JObject { {"minecraft:max_stack_size", Size }};
        }
        public override ListViewItem getViewInfo()
        {
            return new ListViewItem(new string[] { "Max Stack Size", Size.ToString() });
        }

        public override void editComponent()
        {
            InputDialog id = new InputDialog();
            id.setDisplayText("Set Max Stack Size", Size.ToString());
            id.ShowDialog();
            int tSize = 0;
            if (id.input != "" && int.TryParse(id.input, out tSize))
            {
                if (Size > 64)
                    Size = 64;

                if (Size < 1)
                    Size = 1;

                Size = tSize;
            }
        }
    }
}
