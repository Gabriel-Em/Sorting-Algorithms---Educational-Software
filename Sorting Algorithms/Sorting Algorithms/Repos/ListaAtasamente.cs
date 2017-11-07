using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    class ListaAtasamente
    {
        public List<AttachmentElement> Lista { get; private set; }

        public ListaAtasamente()
        {
            Lista = new List<AttachmentElement>();
        }

        public void add(AttachmentElement EA)
        {
            Lista.Add(EA);
        }

        public void remove(int index)
        {
            Lista.RemoveAt(index);
        }
        public int getIndexByName(string name)
        {
            for (int i = 0; i < Lista.Count; i++)
                if (Lista[i].Value == name)
                    return i;
            return -1;
        }

        public AttachmentElement this[int index]
        {
            get { if (index >= 0 && index < Lista.Count) return Lista[index]; else return null; }
            set { if(index >=0 && index <Lista.Count) Lista[index] = value; }
        }
        
        public void Clear()
        {
            Lista = null;
        }
    }
}
