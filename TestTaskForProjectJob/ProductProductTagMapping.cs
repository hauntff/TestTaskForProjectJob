using System;
using System.Collections.Generic;

#nullable disable

namespace TestTaskForProjectJob
{
    public partial class ProductProductTagMapping
    {
        public int ProductTagId { get; set; }
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
