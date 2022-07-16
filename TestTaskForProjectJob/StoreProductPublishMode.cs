using System;
using System.Collections.Generic;

#nullable disable

namespace TestTaskForProjectJob
{
    public partial class StoreProductPublishMode
    {
        public StoreProductPublishMode()
        {
            StoreProducts = new HashSet<StoreProduct>();
        }

        public short Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<StoreProduct> StoreProducts { get; set; }
    }
}
