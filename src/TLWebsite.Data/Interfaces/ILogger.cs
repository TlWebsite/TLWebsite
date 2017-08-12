// Copyright (c) Lakithu. All rights reserved.

namespace TLWebsite.Data.Interfaces
{
    public interface ILogger
    {
        ILogLevel LogIn();

        ILogLevel Posts();

        ILogLevel Data();
    }
}
