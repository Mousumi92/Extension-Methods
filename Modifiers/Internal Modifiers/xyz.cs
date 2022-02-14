using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal_Modifiers
{
     class xyz
    {
        // Will give an error during compilation
        User u1 = new User();
        public xyz()
        {
            u1.Age = 20;
        }

    }
}
