using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class AccountBLL
    {
        public AccountDAL accountDAL { get; set; }
        public AccountBLL() => accountDAL = new AccountDAL();

        public bool isExistAccount(AccountDTO accountDTO)
        {
            bool flag = true;
            AccountDTO reAccountDTO = accountDAL.getAccountDTO(accountDTO.username);
            if (reAccountDTO == null || !accountDTO.password.Equals(reAccountDTO.password))
                flag = false;
            return flag;
        }
        public bool isExistUsername(string username) => accountDAL.isExistUserName(username);
        public bool saveAccountDTO(AccountDTO accountDTO) => accountDAL.saveAccountDTO(accountDTO);


    }
}
