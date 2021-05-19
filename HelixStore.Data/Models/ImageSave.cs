using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelixStore.Data.Models
{
    public class ImageSave
    {
        public string currentPath { get; set; }
        public string toPath { get; set; }

        public string fileName { get; set; }
        public ImageSave(string current, string to, string name)
        {
            currentPath = current;
            toPath = to;
            fileName = name;
        }
        public ImageSave()
        {
            currentPath = null;
            toPath = null;
            fileName = null;
        }
    }
}
