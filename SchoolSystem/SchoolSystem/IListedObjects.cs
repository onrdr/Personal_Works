using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    internal interface IListedObjects<T>
    {
        public string GetName(); 
        public string GetLastName();
        void PrintInfoForAdmin(); 
    }
}

