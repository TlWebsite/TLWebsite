// Copyright (c) Lakithu. All rights reserved.
using System.Collections.Generic;

namespace TLWebsite.Data.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {

        List<User> GetAllActive();

        List<User> GetAllInactive();

        User GetCurrentUser();

        List<DTO.AllComments> AllUserComments(int userID);

        List<DTO.AllComments> AllUserComments(DTO.User user);

        List<DTO.AllComments> AllBulkUserComments(List<int> userIDs);

        List<DTO.AllComments> AllBulkUserComments(List<DTO.User> users);
    }
}
