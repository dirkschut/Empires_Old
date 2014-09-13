using Empires.IO.Packages.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Empires.IO.Packages
{
    public class PackageData
    {
        public String name;
        public String author;
        public String version;
        public String packageID;

        public List<Material> materials = new List<Material>();
    }
}
