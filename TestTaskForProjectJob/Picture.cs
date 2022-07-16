using System;
using System.Collections.Generic;

#nullable disable

namespace TestTaskForProjectJob
{
    public partial class Picture
    {
        public Picture()
        {
            ProductPictureMappings = new HashSet<ProductPictureMapping>();
        }

        public int Id { get; set; }
        public byte[] PictureBinary { get; set; }
        public string MimeType { get; set; }
        public string SeoFilename { get; set; }
        public bool IsNew { get; set; }
        public DateTime CreatedOnUtc { get; set; }

        public virtual ICollection<ProductPictureMapping> ProductPictureMappings { get; set; }
    }
}
