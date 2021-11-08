using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    /*
     *  This class use to read and write account information to file 
     */
    public class AccountDAL
    {
        private List<AccountDTO> accountDTOs; // list of accounts
        private FileDAL fileDAL; //use for interating with file

        //constructor
        public AccountDAL()
        {
            accountDTOs = new List<AccountDTO>();
            fileDAL = new FileDAL(FilePath.accountFilePath);
        }
        //check username is valid or not
        public bool isValidUsername(string username) => !string.IsNullOrEmpty(username.Trim());
        //check the username is already exist or not
        public bool isExistUserName(string username) => isValidUsername(username) &&
            fileDAL.readDataFromFile()?.Find(e => e[0].Equals(FileDAL.encodeString(username)))!=null ;

        /*
         * This method uses for get all information of account from file 
         * if can't read file cause by wrong file path or there haven't any account information in 
         * file, return null. Otherwise, return list of AccountDTO object
         */
        public List<AccountDTO> getAccountDTO()
        {
            accountDTOs.Clear();
            fileDAL.readDataFromFile()?.ForEach(e => accountDTOs.Add(
                new AccountDTO( FileDAL.decodeString(e[0]),FileDAL.decodeString(e[1]))));
            if (accountDTOs.Count <= 0) 
                return null;
            return accountDTOs;
        }

        /*
         * This method will gets specific account from file with specific username
         * if not found, return null. otherwise, return an AccountDTO object;
         */
        public AccountDTO getAccountDTO(string username) => 
            getAccountDTO()?.Find(e => e.username.Equals(username));

        /*
         * This method will save all of information of accounts into file
         * if account list is empty or fail to save file, return false. otherwise, return true
         */
        public bool saveAccountDTO()
        {
            if (accountDTOs.Count == 0)
                return false;
            List<List<string>> datas = new List<List<string>>();
            accountDTOs.ForEach(e =>
            {
                List<string> line = new List<string>();
                line.Add(FileDAL.encodeString(e.username));
                line.Add(FileDAL.encodeString(e.password));
                datas.Add(line);
            });
            fileDAL.datas = datas;
            return fileDAL.writeDataToFile();
        }

        /*
         * This method will appends informaion of an account to last line of file
         * if passed account is null or writing information of account to file is failed, return false;
         * if username of passed account is already exist in file, remove exist account and save new account to file
         * return true if save account successfully
         */
        public bool saveAccountDTO(AccountDTO account)
        {
            if (account == null || isExistUserName(account.username))
                return false;
            List<string> line = new List<string>();
            line.Add(FileDAL.encodeString(account.username));
            line.Add(FileDAL.encodeString(account.password));
            return fileDAL.writeLineData(line);
        }
    }

}