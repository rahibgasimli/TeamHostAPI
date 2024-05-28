using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamHost.DAL.Enums;

namespace TeamHost.DAL.Entities
{
    public class Friendship : BaseEntity
    {
        public List<AppUser> Friends { get; set; }
        public FriendshipStatus Status { get; set; }
    }
}
