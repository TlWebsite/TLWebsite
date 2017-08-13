// Copyright (c) Lakithu. All rights reserved.

using System.Collections.Generic;

namespace TLWebsite.Data.DTO
{
    public class MediaType
    {
        public int MediaTypeID { get; set; }

        public string Name { get; set; }

        public ICollection<Media> Media { get; set; }
    }
}
