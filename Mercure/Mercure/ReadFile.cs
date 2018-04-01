using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace Mercure
{
    class ReadFile
    {
        string filename;
        string filepath;

        public void LoadFile(string filename) {

            XmlDocument xf = new XmlDocument();
            xf.Load(filename);
            
        }
     
       

    }
}
