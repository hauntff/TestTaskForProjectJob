using System;
using System.Collections.Generic;

#nullable disable

namespace TestTaskForProjectJob
{
    public partial class PiCategoriesMapping
    {
        public int Id { get; set; }
        public int? PiCategoryId { get; set; }
        public int? CategoryId { get; set; }
        public int? PiParentId { get; set; }
    }
}
