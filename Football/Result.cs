using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Result
    {
        public int Id { get; set; }
        public int IdOfTournament { get; set; }
        public int IdOfFirstPlace { get; set; }
        public int IdOfSecondPlace { get; set; }
        public string Score { get; set; }
        public string DateOfResult { get; set; }


    }
}
