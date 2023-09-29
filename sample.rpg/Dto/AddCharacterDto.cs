using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample.rpg.Dto
{
    public class AddCharacterDto
    {
          public int Id{ get; set; }
        public string Name { get; set; }="Frodo";
        public int Strength { get; set; }=18;
        public int Intelligence { get; set; }=20;
        public int Defence { get; set; }=30;
    }
}