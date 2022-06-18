using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCAPP.Data
{
    class Category
    {
        public int id_Category { get; set; }
        public string Description { get; set; }
        public Category()
        {

        }

        public Category(int id_Category, string Description)
        {
            this.id_Category = id_Category;
            this.Description = Description;
        }
    }
}
