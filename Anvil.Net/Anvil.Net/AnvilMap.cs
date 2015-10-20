using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Anvil.Net.Internals;
using fNbt;

namespace Anvil.Net
{
    public class AnvilMap
    {
        //public
        public MapData MapData { get; set; }

        //private
        private string _path { get; set; }
        

        public AnvilMap(string path)
        {
            //Ctor's
            MapData = new MapData();
          
            //LoadMap
            _path = path;
            Load(Path.Combine(_path, "level.dat"));
        }

        public void Load(string path)
        {
            //load nbt file
            var file = new NbtFile(path);

            //loop the data tag
            foreach (var i in ((NbtCompound) file.RootTag.First()))
            {
                //cast to dynamic
                dynamic val = i;
                //is it the gamerules tag
                if (i.Name == "GameRules")
                {//yes, loop all data in game rule tag
                    foreach (var x in ((NbtCompound) i))
                    {
                        dynamic valx = x;
                        SetValue(UppercaseFirst(x.Name), valx.Value, MapData.GameRules);//set value
                    }
                }
                else
                {//no, greate just set the value
                    SetValue(UppercaseFirst(i.Name), val.Value, MapData);//set value
                }
            }
        }

        private void SetValue(string name, object value, object victim)
        {
            PropertyInfo propertyInfo = victim.GetType().GetProperty(name);
            propertyInfo?.SetValue(victim, Convert.ChangeType(value, propertyInfo.PropertyType), null);
        }

        public void Save()
        {
            //Create nbt file
            var file = new NbtFile();
            var data = new NbtCompound() {Name = "Data"};

           
            file.RootTag.Add(data);
        }

        

        private string UppercaseFirst(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            return char.ToUpper(s[0]) + s.Substring(1);
        }

    }
}
