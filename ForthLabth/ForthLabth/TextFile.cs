using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ForthLabth
{
    [Serializable]
    public class TextFile
    {
        public string Text { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string Info { get; set; }
        public string[] KeyWords { get; set; }

        public TextFile()
        {
            KeyWords = new[] {"TextFile"};
        }

        public override string ToString()
        {
            string keys = "";
            KeyWords.ToList().ForEach(x => keys+=x + ", ");
            return string.Format("Name: {0} Path: {1} Info: {2} Keys: {3}", Name,Path, Info, keys); 
        }

        public void Serialize(FileStream fs)
        {
            XmlSerializer  xs = new XmlSerializer(this.GetType());
            xs.Serialize(fs,this);
            fs.Flush();
            fs.Close();
        }

        public void Deserialize(FileStream fs)
        {
            XmlSerializer xs = new XmlSerializer(this.GetType());
            TextFile txtFile = (TextFile)xs.Deserialize(fs);
            Text = txtFile.Text;
            Name = txtFile.Name;
            Path = txtFile.Path;
            KeyWords = txtFile.KeyWords;
            fs.Close();
        }
    }
}
