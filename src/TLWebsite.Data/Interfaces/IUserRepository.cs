// Copyright (c) Lakithu. All rights reserved.
using System.Collections.Generic;

namespace TLWebsite.Data.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        IEnumerable<User> GetAllActive();

        IEnumerable<User> GetAllInactive();

        User GetCurrentUser();

        User GetFullUserInfo(int userID);

    }
}
