using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace uwp
{
    internal class PagesList
    {
        public static Type choose_page(string tag)
        {
            Type type = Assembly.GetExecutingAssembly().GetType($"uwp.{tag}");
            return type;
        }
    }
}
