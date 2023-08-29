using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave3._1
{
    internal class Collection<TKey>
    {
        private readonly Dictionary<TKey, Medarbejder> 
            _collection = new Dictionary<TKey, Medarbejder>();

        public void addElement(TKey key, Medarbejder value)
        {
            if (this._collection.ContainsKey(key))
            {
                return;
            }
            _collection.Add(key, value);
        }

        public Medarbejder GetMedarbejder(TKey key)
        {
            if (_collection.ContainsKey(key))
            {
                return _collection[key];
            } else { 
                return null; 
            };
        }

        public int size() { 
            return _collection.Count; 
        }


    }
}
