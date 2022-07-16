using System;
using System.Collections.Generic;

#nullable disable

namespace TestTaskForProjectJob
{
    public partial class PiCategory
    {
        public PiCategory()
        {
            PiCategoriesCategories = new HashSet<PiCategoriesCategory>();
        }

        public int Id { get; set; }
        public int? PiParentId { get; set; }
        public int? CategoryLevel { get; set; }
        public string ImportingCategoryName { get; set; }
        public DateTime? CreatedOnUtc { get; set; }
        public DateTime? UpdatedOnUtc { get; set; }

        public virtual ICollection<PiCategoriesCategory> PiCategoriesCategories { get; set; }
    }
}
