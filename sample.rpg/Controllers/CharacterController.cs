using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace sample.rpg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterServices _characterService;

        public CharacterController(ICharacterServices characterService)
         {
            _characterService = characterService;
        }
       [HttpGet]
       public async Task<ActionResult< ServiceResponse<List<GetCharacterDto>>>>GetCharacter()
       {
          return Ok(await _characterService.GetCharacters());
       }
        [HttpGet("{id}")]
       public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> GetCharacterById(int id)
       {
            
           
          return Ok(await _characterService.GetCharacterById(id));
       }
       [HttpPost]
       public async Task<IActionResult> AddCharacter(AddCharacterDto newCharacter )
       {
         

         return Ok(await _characterService.AddCharacter(newCharacter));
       }
       [HttpPut]
        public async Task < IActionResult> Updatecharacter(UpdateCharacterDto updateCharacter)
        {
        
      

        return Ok(await _characterService.Updatecharacter(updateCharacter));

       }
       [HttpDelete]
       public async Task<IActionResult> DeleteCharacter(int id)
       {
        
        return Ok(await _characterService.DeleteCharacter(id));
       }
       
    }
}