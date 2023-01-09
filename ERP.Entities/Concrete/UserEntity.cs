using ERP.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Entities.Concrete
{
    public class UserEntity : CoreEntity
    {
        public UserEntity()
        {

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Title { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public DateTime? LastLogin { get; set; }
        public string? LastIPAddress { get; set; }
    }
}
