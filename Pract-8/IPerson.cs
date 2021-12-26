using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract_8
{
    interface IPerson
    {
        string FirstName { get; set; }
        string ShowNamePatronymic();
    }
}
