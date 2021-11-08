using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{

    /*
     * This class represents for the each character in game
     */
    public class CharacterDTO
    {
        public string username { get; set; } // username of the character
        public string name { get; set; }// name of the character
        public int score { get; set; } // score of the character
        public CharacterDTO()
        {
            username = name = String.Empty;
            score = 0;
        }
        public CharacterDTO(string username, string name, int score)
        {
            this.username = username;
            this.name = name;
            this.score = score;
        }
    }
 
}
