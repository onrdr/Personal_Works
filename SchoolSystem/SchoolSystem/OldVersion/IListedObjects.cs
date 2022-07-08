using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldVersion
{
    internal interface IListedObjects<T>
    {
        string GetName();
        string GetLastName();
        string GetFullName();
        void PrintInfoForAdmin();
    }
}

