// Copyright (c) Lakithu. All rights reserved.
using System.Web;

namespace TLWebsite.Data.Interfaces
{
    public interface IMediaRepository : IBaseRepository<Media>
    {
        void UploadMedia(HttpFileCollection media);

        void HardDeleteMedia(int mediaID);

        void HardDeleteMEdia(Media media);
    }
}
