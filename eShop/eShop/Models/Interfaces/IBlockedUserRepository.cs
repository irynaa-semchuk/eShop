using eShop.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Models.Interfaces
{
    interface IBlockedUserRepository
    {
        IQueryable<BlockedUser> BlockedUsers { get; }

        void SaveBlockedUser(BlockedUser blockedUser);

        BlockedUser DeleteBlockedUser(string blockedUserId);

        BlockedUser GetBlockedUser(string blockedUserId);
    }
}
