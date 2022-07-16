using System;
using System.Collections.Generic;

#nullable disable

namespace TestTaskForProjectJob
{
    public partial class PiCategoriesCategory
    {
        public int CategoryId { get; set; }
        public string Pipath { get; set; }
        public int? ParentCategoryId { get; set; }
        public int PiCategoryId { get; set; }
        public int CategoryTreeId { get; set; }

        public virtual Category Category { get; set; }
        public virtual PiCategory PiCategory { get; set; }
    }
}
