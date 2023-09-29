using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace sample.rpg.Services
{
    public interface ICharacterServices
    {
        Task<ServiceResponse<List<GetCharacterDto>>> GetCharacters();
       Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);
        Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter );

     Task<ServiceResponse<GetCharacterDto>> Updatecharacter(UpdateCharacterDto updateCharacter);
    Task<ServiceResponse<List<GetCharacterDto>>> DeleteCharacter(int id);
    }
}