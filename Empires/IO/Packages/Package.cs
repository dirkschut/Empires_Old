using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Empires.IO.Packages
{
    class Package
    {
        private String path;

        public Package(String path)
        {
            this.path = path;
        }

        public String getPath()
        {
            return this.path;
        }
    }
}
