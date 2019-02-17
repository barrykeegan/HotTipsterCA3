using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotTipsterCA3
{
    [Serializable]
    public class TipResults : ICollection<TipResult>
    {
        private List<TipResult> ResultList = new List<TipResult>();

        public int Count
        {
            get
            {
                return ResultList.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

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
            ResultList.Add(item);
        }

        public void Clear()
        {
            ResultList.Clear();
        }

        public bool Contains(TipResult item)
        {
            return ResultList.Contains(item);
        }

        public void CopyTo(TipResult[] array, int arrayIndex)
        {
            ResultList.CopyTo(array, arrayIndex);
        }

        public IEnumerator<TipResult> GetEnumerator()
        {
            return ResultList.GetEnumerator();
        }

        public bool Remove(TipResult item)
        {
            return ResultList.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
