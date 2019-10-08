using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Snippets
{
    class CompassCollection : ICollection
    {
        // Array containing values in this collection
        string[] compassPoints = { };

        public int Count => ((ICollection)compassPoints).Count;

        public object SyncRoot => compassPoints.SyncRoot;

        public bool IsSynchronized => compassPoints.IsSynchronized;

        public void CopyTo(Array array, int index)
        {
            compassPoints.CopyTo(array, index);
        }

        public IEnumerator GetEnumerator()
        {
            return compassPoints.GetEnumerator();
        }
    }
}
