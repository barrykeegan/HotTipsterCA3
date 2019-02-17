using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotTipsterCA3
{
    public class TipResult: IEquatable<TipResult>
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
            if(string.IsNullOrEmpty(Course))
            {
                return false;
            }
            //Earliest tip results available are from 2016, this value is added to App.Config AppSettings key 
            //"earliestTipYear". This allows for config file to be edited simply, to allow for Tips from 
            //earlier years.
            //Also tipResults from the future can't be known, so if RaceDate is greater than now it can't be valid data            
            if (RaceDate.Year < int.Parse(ConfigurationManager.AppSettings["earliestTipYear"]) || RaceDate > DateTime.Now)
            {
                return false;
            }
            //From sample data HotTipster seems to bet a minimum of 10 euro on a race. 
            //If value less than that, then not a valid bet value.
            //If HotTipster won his bet, the value will also be bigger than the amount bet.
            if (ResultValue < 10.00m)
            {
                return false;
            }
            //There is no real way to validate Won property, 
            //since it will initialise to false which is a valid value
            return true;
        }

        public override bool Equals(object obj)
        {
            return this.Equals((TipResult)obj);
        }

        public bool Equals(TipResult other)
        {
            if(other == null)
            {
                return false;
            }
            if(Course == other.Course && RaceDate == other.RaceDate && ResultValue == other.ResultValue && Won == other.Won)
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            var hashCode = -1515630888;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Course);
            hashCode = hashCode * -1521134295 + RaceDate.GetHashCode();
            hashCode = hashCode * -1521134295 + ResultValue.GetHashCode();
            hashCode = hashCode * -1521134295 + Won.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(TipResult tr1, TipResult tr2)
        {
            if( object.ReferenceEquals(tr1, null) )
            {
                return object.ReferenceEquals(tr2, null);
            }
            return tr1.Equals((TipResult)tr2);
        }

        public static bool operator !=(TipResult tr1, TipResult tr2)
        {
            if (object.ReferenceEquals(tr1, null))
            {
                return !(object.ReferenceEquals(tr2, null));
            }
            return !( tr1.Equals((TipResult)tr2));
        }
    }
}
