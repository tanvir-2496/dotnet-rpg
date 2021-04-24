using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg.Models;

namespace dotnet_rpg.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
       private static List<Character> character = new List<Character>{
    new Character(),
    new Character{Id=1,Name = "Tanvir"}
    }; 
        public async Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter)
        {
            ServiceResponse<List<Character>> serviceResponse = new ServiceResponse<List<Character>>();
            character.Add(newCharacter);
            serviceResponse.Data=character;
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Character>>> GetAllCharacters()
        {
           ServiceResponse<List<Character>> serviceResponse = new ServiceResponse<List<Character>>();
           serviceResponse.Data=character;
           return serviceResponse;
        }

        public async Task<ServiceResponse<Character>> GetCharacterById(int id)
        {
            ServiceResponse<Character> serviceResponse = new ServiceResponse<Character>();
            serviceResponse.Data=character.FirstOrDefault(c=>c.Id==id);
            return serviceResponse;
        }
    }
}