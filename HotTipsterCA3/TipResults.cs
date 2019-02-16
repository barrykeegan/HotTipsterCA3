using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotTipsterCA3
{
    public class TipResults : ICollection<TipResult>
    {
        private List<TipResult> Results = new List<TipResult>();

        public int Count
        {
            get
            {
                return Results.Count;
            }
        }

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(TipResult item)
        {
            if(item==null)
            {
                throw new ArgumentNullException("Attempted to add null item to list");
            }
            if(!item.IsValidResult())
            {
                throw new ArgumentException("One or more properties have invalid data assigned" + Environment.NewLine + item.ToString());
            }
            Results.Add(item);
        }

        public void Clear()
        {
            Results.Clear();
        }

        public bool Contains(TipResult item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(TipResult[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<TipResult> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(TipResult item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
