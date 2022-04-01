using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Library
{
    internal static class Empty
    {
        private static bool XmlNode_IsNullOrNoChild(XmlNode node) 
        {
            bool empty = false;

            if (node == null)
                empty = true;
            else
            {
                if (node.ChildNodes.Count == 0)
                    empty = true;
            }
            return empty;
        }
    }
}
