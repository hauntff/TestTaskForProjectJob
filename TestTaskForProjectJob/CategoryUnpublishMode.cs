using System;
using System.Collections.Generic;

#nullable disable

namespace TestTaskForProjectJob
{
    public partial class CategoryUnpublishMode
    {
        public CategoryUnpublishMode()
        {
            Categories = new HashSet<Category>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Days { get; set; }
        public bool Enabled { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
    }
}
