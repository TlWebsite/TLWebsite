// Copyright (c) Lakithu. All rights reserved.

using System;
using System.Collections.Generic;
using TLWebsite.Data.DTO;
using TLWebsite.Data.Interfaces;
using TLWebsite.Data;

namespace TLWebsite.Data.Repositories
{
    public class UserRepository : IUserRepository
    {

        public List<AllComments> AllBulkUserComments(List<int> userIDs)
        {
            throw new NotImplementedException();
        }

        public List<AllComments> AllBulkUserComments(List<DTO.User> users)
        {
            throw new NotImplementedException();
        }

        public List<AllComments> AllUserComments(int userID)
        {
            throw new NotImplementedException();
        }

        public List<AllComments> AllUserComments(DTO.User user)
        {
            throw new NotImplementedException();
        }

        public List<DTO.User> BulkCreate(List<DTO.User> users)
        {
            throw new NotImplementedException();
        }

        public List<DTO.User> BulkDelete(List<DTO.User> users)
        {
            throw new NotImplementedException();
        }

        public List<DTO.User> BulkDelete(List<int> users)
        {
            throw new NotImplementedException();
        }

        public List<DTO.User> BulkFetch(List<int> userIDs)
        {
            throw new NotImplementedException();
        }

        public List<DTO.User> BulkUpdate(List<DTO.User> users)
        {
            throw new NotImplementedException();
        }

        public DTO.User Create(DTO.User user)
        {
            throw new NotImplementedException();
        }

        public DTO.User Delete(DTO.User user)
        {
            throw new NotImplementedException();
        }

        public DTO.User Delete(int userId)
        {
            throw new NotImplementedException();
        }

        public DTO.User Fetch(int userID)
        {
            throw new NotImplementedException();
        }

        public List<DTO.User> FindAll()
        {
            throw new NotImplementedException();
        }

        public List<DTO.User> FindAllActive()
        {
            throw new NotImplementedException();
        }

        public DTO.User Update(DTO.User user)
        {
            throw new NotImplementedException();
        }
    }
}
