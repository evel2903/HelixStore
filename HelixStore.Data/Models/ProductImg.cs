using System;
using System.Collections.Generic;

#nullable disable

namespace HelixStore.Data.Models
{
    public partial class ProductImg
    {
        public int ProductImgId { get; set; }
        public int ProductImgUrl { get; set; }
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
