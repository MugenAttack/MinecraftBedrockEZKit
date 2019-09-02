using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Newtonsoft.Json.Linq;
using System.IO;

namespace MinecraftBedrockEZKit
{
    class MCItem
    {
        public string name;
        public string displayName;
        public string category;
        public Image img;
        public List<ItemComponents> iComponents = new List<ItemComponents>();

        public void create(profileData pd)
        {

            //behavior pack item folder json
            JObject components = new JObject();
            foreach (ItemComponents ic in iComponents)
                components.Merge(ic.getJSON());

            JObject beh = new JObject
            {
                {"format_version", pd._version },
                {"minecraft:item", new JObject{
                    {"description", new JObject{{"identifier", pd._namespace + ":" + name.Replace(" ","_")} } },
                    { "components", components }
                }
                }
            };

            string jsonsave = beh.ToString();
            System.IO.File.WriteAllText(pd._behaviorPack + "/items/" + name.Replace(" ", "_") + ".json", jsonsave);

            //resource pack item folder json
            JObject res = new JObject
            {
                {"format_version", pd._version },
                {"minecraft:item", new JObject{
                    {"description", new JObject{
                        { "identifier", pd._namespace + ":" + name.Replace(" ","_") },
                        { "category", category }}
                    },
                    { "components", new JObject {
                        { "minecraft:icon", name.Replace(" ","_") },
                        { "minecraft:render_offsets", "tools" } }
                    }
                }
                }
            };

            jsonsave = res.ToString();
            System.IO.File.WriteAllText(pd._resourcePack + "/items/" + name.Replace(" ", "_") + ".json", jsonsave);

            //texture register and save
            string txtTex = System.IO.File.ReadAllText(pd._resourcePack + "/textures/" + "item_texture.json");
            JObject texData = JObject.Parse(txtTex);
            JObject texlist = (JObject)texData["texture_data"];
            texlist.Add(name.Replace(" ", "_"), new JObject { { "textures", "textures/items/" + name.Replace(" ", "_") + ".png" } });
            System.IO.File.WriteAllText(pd._resourcePack + "/textures/" + "item_texture.json", texData.ToString());
            img.Save(pd._resourcePack + "/textures/items/" + name.Replace(" ", "_") + ".png", System.Drawing.Imaging.ImageFormat.Png);

            //add to language files
            string[] files = System.IO.Directory.GetFiles(pd._resourcePack + "/texts");
            for (int i = 0; i < files.Length; i++)
            {
                using (StreamWriter sw = File.AppendText(files[i]))
                {
                    sw.WriteLine("item." + pd._namespace + ":" + name.Replace(" ", "_") + ".name=" + displayName);
                }
            }
        }
    }
}
