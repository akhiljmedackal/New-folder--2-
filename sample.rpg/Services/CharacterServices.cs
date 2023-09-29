using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace sample.rpg.Services
{
    public class CharacterServices : ICharacterServices
    {
          private static List<Character>characters=new List<Character>
       {
         new Character(),
         new Character{
            Id=2,
            Name="akhil"
         }
       };
        private readonly IMapper _mapper;

        public CharacterServices(IMapper mapper)
       {
           _mapper = mapper;
        }
        public async Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter)
        {
            var serviceResponse =new ServiceResponse<List<GetCharacterDto>>();
            var character=_mapper.Map<Character>(newCharacter);
            character.Id=characters.Max(c=>c.Id)+1;
            characters.Add(character);
            serviceResponse.Data=characters.Select(c=>_mapper.Map<GetCharacterDto>(c)).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetCharacterDto>>> DeleteCharacter(int id)
        {
            var serviceResponse=new ServiceResponse<List<GetCharacterDto>>();
             var cha=characters.First(c=>c.Id==id);
        characters.Remove(cha);
        serviceResponse.Data=characters.Select(c=>_mapper.Map<GetCharacterDto>(c)).ToList();
        return serviceResponse;
        }

        public async Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id)
        {
             var serviceResponse=new ServiceResponse<GetCharacterDto>();
            var de=characters.FirstOrDefault(c=>c.Id==id);
            serviceResponse.Data=_mapper.Map<GetCharacterDto>(de);
            return serviceResponse;
             
        }

        public async Task<ServiceResponse<List<GetCharacterDto>>> GetCharacters()
        {
            var serviceResponse=new ServiceResponse<List<GetCharacterDto>>();
            serviceResponse.Data=characters.Select(c=>_mapper.Map<GetCharacterDto>(c)).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetCharacterDto>> Updatecharacter(UpdateCharacterDto updateCharacter)
         {
             var serviceResponse=new ServiceResponse<GetCharacterDto>();
            var cha= characters.FirstOrDefault(c=>c.Id==updateCharacter.Id);
            
      
       
             cha.Id= updateCharacter.Id;

             cha.Name=updateCharacter.Name;

            serviceResponse.Data = _mapper.Map<GetCharacterDto>(cha);
            @Console.WriteLine(characters);
      

         return serviceResponse;
         }
    }
}