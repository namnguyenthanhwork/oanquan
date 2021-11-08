using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    //this class represents for the account of each user
    public class AccountDTO 
    {
        public string username { get; set; } // username of account
        public string password { get; set; } // password of account

        public AccountDTO()=>
            username = password = String.Empty;
      
        public AccountDTO(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }
}
