using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Representations
    {
        public List<Representation> representations { get; set; }
    }

    public class Representation
    {
        public int ID { get; set; }
        public string Country { get; set; }
        public string Alternate_Name { get; set; }
        public string FIFA_Code { get; set; }
        public int Group_ID { get; set; }
        public string Group_Letter { get; set; }
        public int Wins { get; set; }
        public int Draws { get; set; }
        public int Losses { get; set; }
        public int Games_Played { get; set; }
        public int Points { get; set; }
        public int Goals_For { get; set; }
        public int Goals_Against { get; set; }
        public int Goal_Differential { get; set; }

        public override string ToString() => $"{ID},{Country},{Alternate_Name},{FIFA_Code},{Group_ID},{Group_Letter},{Wins},{Draws},{Losses},{Games_Played}, {Points}, {Goals_For}, {Goals_Against}, {Goal_Differential}";
    }
}
