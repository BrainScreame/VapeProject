using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VapeApplication
{
    class Category
    {
        private int id;
        private String name;

        public int Id
        {
            get { return id; }
        }

        public String Name
        {
            get { return name; }
        }


        public Category(int id, String name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
