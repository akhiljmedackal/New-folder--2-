using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace sample.rpg
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
           CreateMap<Character,GetCharacterDto>();
           CreateMap<AddCharacterDto,Character>();

        }
    }
}