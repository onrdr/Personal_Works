using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholManagementSystem
{
    internal interface IListedObjects<T>
    {
        string GetName();

        string GetLastName();

        void PrintInfoForAdmin();

        T FindandReturn(string name, string lastName); 
    }
}

