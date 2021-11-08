using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class CharacterBLL
    {
        public CharacterDAL characterDAL { get; set; }
        public CharacterBLL() => characterDAL = new CharacterDAL();
        public bool isExistUserName(string username) => characterDAL.isAlreadyUserName(username);
        public bool isExitName(string name) => characterDAL.isAlreadyName(name);
        public bool saveCharacterDTO(CharacterDTO characterDTO) => characterDAL.saveCharacterDTO(characterDTO);
        public List<CharacterDTO> getCharacterDTOs() => characterDAL.getCharacterDTOs();
        public CharacterDTO getCharacterDTO(string username) => characterDAL.getCharacterDTO(username);
    }
}
