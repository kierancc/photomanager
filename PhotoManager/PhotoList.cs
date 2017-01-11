using System.Collections.Generic;
using System.Linq;

namespace PhotoManager
{
    public class PhotoList
    {
        protected Dictionary<string, HashSet<string>> map;

        public PhotoList()
        {
            map = new Dictionary<string, HashSet<string>>();
        }

        public void AddPhoto(string fileName)
        {
            string nameOnly = fileName.Substring(0, fileName.LastIndexOf("."));
            string extensionOnly = fileName.Substring(fileName.LastIndexOf(".") + 1).ToUpper();

            TryAddValue(nameOnly, extensionOnly);
        }

        public List<string> GetExtensions()
        {
            return map.Keys.ToList();
        }

        public HashSet<string> GetFileNames(string extension)
        {
            if (map.ContainsKey(extension))
            {
                return map[extension];
            }
            else
            {
                return null;
            }
        }

        protected void TryAddValue(string name, string extension)
        {
            if (! map.ContainsKey(extension))
            {
                map[extension] = new HashSet<string>();
            }

            map[extension].Add(name);
        }
    }
}
