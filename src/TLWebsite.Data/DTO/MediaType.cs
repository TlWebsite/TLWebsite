// Copyright (c) Lakithu. All rights reserved.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLWebsite.Data.DTO
{
    public class MediaType
    {
        public int MediaTypeID { get; set; }

        public string Name { get; set; }

        public ICollection<Media> Media { get; set; }
    }
}
