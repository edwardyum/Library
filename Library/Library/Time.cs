using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    // ПЕРЕНЕСТИ КЛАСС Time ИЗ ПРОГРАММЫ - ТАМ НАКОПИЛОСЬ УЖЕ МНОГО ИЗМЕНЕНИЙ

    public static class Time
    {

        // доделать метод - учесть разные актуальные форматы дат и времени
        // выделение отдельного метода полезно, поскольку можно не запоминать параметры, например: G
        public static string now()
        {
            return DateTime.Now.ToString("G");
        }
    }
}
