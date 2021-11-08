using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    /*
    *  This class use to read and write character information to file 
    */
    public class CharacterDAL
    {
        private List<CharacterDTO> characterDTOs; // list of character information
        private FileDAL fileDAL;// use for interating with file

        //constructor
        public CharacterDAL()
        {
            characterDTOs = new List<CharacterDTO>();
            fileDAL = new FileDAL(FilePath.characterFilePath);
        }
        //check the username is valid or not
        public bool isValidUsername(string username) => !string.IsNullOrEmpty(username.Trim());

        //check the name is valid or not
        public bool isValidName(string name) => !string.IsNullOrEmpty(name.Trim());
        //check the username is already exist or not

        public bool isAlreadyUserName(string username) => isValidUsername(username) &&
            fileDAL.readDataFromFile()?.Find(e => e[0].Equals(FileDAL.encodeString(username))) != null;

        //check the name is already exist or not
        public bool isAlreadyName(string name) => isValidName(name) &&
            fileDAL.readDataFromFile()?.Find(e => e[1].Equals(FileDAL.encodeString(name))) != null;

        /*
         * This method uses for get all information of character from file 
         * if can't read file cause by wrong file path or there haven't any character information in 
         * file, return null. Otherwise, return list of CharacterDTO objects
         */
        public List<CharacterDTO> getCharacterDTOs()
        {
            characterDTOs.Clear();
            fileDAL.readDataFromFile()?.ForEach(e =>
                characterDTOs.Add(new CharacterDTO(FileDAL.decodeString(e[0]),
                                                    FileDAL.decodeString(e[1]), 
                                                    Int32.Parse(FileDAL.decodeString(e[2])))));
            return characterDTOs;
        }


        /*
         * This method will gets specific character information from file with specific username
         * if not found, return null. otherwise, return an CharacterDTO object;
         */
        public CharacterDTO getCharacterDTO(string username) =>
            getCharacterDTOs()?.Find(e => e.username.Equals(username));

        /*
         * This method will save all of information of characters into file
         * if character list is empty or fail to save file, return false. otherwise, return true
         */
        public bool saveCharacterDTO()
        {
            if (characterDTOs.Count == 0)
                return false;
            List<List<string>> dt = new List<List<string>>();
            characterDTOs.ForEach(e =>
            {
                List<string> line = new List<string>();
                line.Add(FileDAL.encodeString(e.username));
                line.Add(FileDAL.encodeString(e.name));
                line.Add(FileDAL.encodeString(e.score.ToString()));
                dt.Add(line);
            });
            fileDAL.datas = dt;
            return fileDAL.writeDataToFile();
        }

        /*
        * This method will appends informaion of an character to last line of file
        * if passed character is null or write information of character to file is failed, return false;
        * if username of passed character is already exist in file, remove exist character and 
        * save new character to file
        * Otherwise, return true;
        */
        public bool saveCharacterDTO(CharacterDTO character)
        {
            if (character == null)
                return false;
            if (isAlreadyUserName(character.username) && isAlreadyName(character.name))
            {
                getCharacterDTOs();
                characterDTOs.Remove(characterDTOs.Find(
                    e => e.username.Equals(character.username) && e.name.Equals(character.name)));
                characterDTOs.Add(character);
                return saveCharacterDTO();
            }
            List<string> line = new List<string>();
            line.Add(FileDAL.encodeString(character.username));
            line.Add(FileDAL.encodeString(character.name));
            line.Add(FileDAL.encodeString(character.score.ToString()));
            return fileDAL.writeLineData(line);
        }
    }
}
