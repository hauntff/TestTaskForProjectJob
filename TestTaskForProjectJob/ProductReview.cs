using System;
using System.Collections.Generic;

#nullable disable

namespace TestTaskForProjectJob
{
    public partial class ProductReview
    {
        public ProductReview()
        {
            ProductReviewHelpfulnesses = new HashSet<ProductReviewHelpfulness>();
        }

        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Title { get; set; }
        public string ReviewText { get; set; }
        public int Rating { get; set; }
        public int HelpfulYesTotal { get; set; }
        public int HelpfulNoTotal { get; set; }

        public virtual Product Product { get; set; }
        public virtual ICollection<ProductReviewHelpfulness> ProductReviewHelpfulnesses { get; set; }
    }
}
