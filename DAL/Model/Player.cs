using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Starting_Eleven
    {
        public List<Player> Players { get; set; }
    }
    public class Player
    {
        public string Name { get; set; }
        public bool Captain { get; set; }
        public int Shirt_Number { get; set; }
        public string Position { get; set; }
    }
}
