using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotTipsterCA3
{
    public class TipResult
    {
        public string Course { get; set; }
        public DateTime RaceDate { get; set; }
        public decimal ResultValue { get; set; }
        public bool Won { get; set; }

        public override string ToString()
        {
            return $"{nameof(Course)}: {Course}{Environment.NewLine}" +
                   $"{nameof(RaceDate)}: {RaceDate}{Environment.NewLine}" +
                   $"{nameof(ResultValue)}: {ResultValue}{Environment.NewLine}" +
                   $"{nameof(Won)}: {Won}{Environment.NewLine}";
        }

        public bool IsValidResult()
        {
            
            return true;
        }
    }
}
