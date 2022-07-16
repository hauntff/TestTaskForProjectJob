using System;
using System.Collections.Generic;

#nullable disable

namespace TestTaskForProjectJob
{
    public partial class CategoryTreeLeaf
    {
        public int Id { get; set; }
        public bool Published { get; set; }
        public int CategoryTreeId { get; set; }
        public int ParentCategoryTreeLeafId { get; set; }
        public int? TopParentCategoryTreeLeafId { get; set; }
        public int CategoryId { get; set; }
        public int? ParentCategoryId { get; set; }
        public int? TopParentCategoryId { get; set; }
        public string CategoryName { get; set; }
        public string ParentCategoryName { get; set; }
        public string TopParentCategoryName { get; set; }
        public string CategoryIdPath { get; set; }
        public string CategoryNamePath { get; set; }
        public string CategoryUrlPath { get; set; }
        public bool? ShowOnHomePage { get; set; }
        public int? ShortcutToCategoryId { get; set; }
        public int? DisplayOrder { get; set; }
        public string Url { get; set; }
        public DateTime? CreatedOnUtc { get; set; }
        public DateTime? UpdatedOnUtc { get; set; }
    }
}
