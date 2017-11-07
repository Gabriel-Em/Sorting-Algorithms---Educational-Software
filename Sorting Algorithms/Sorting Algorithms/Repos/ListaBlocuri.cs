using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    class ListaBlocuri
    {
        public List<SortingElement> VisualElements { get; private set; }
        public List<int> IntegerElements { get; private set; }

        public ListaBlocuri(List<int> lista)
        {
            IntegerElements = lista;
            generateVisualElements();
        }

        public void generateVisualElements()
        {
            VisualElements = new List<SortingElement>();

            foreach (int element in IntegerElements)
            {
                SortingElement SE = new SortingElement(element);
                VisualElements.Add(SE);
            }
        }

        public void Clear()
        {
            VisualElements = null;
            IntegerElements = null;
        }
    }
}
