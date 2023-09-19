using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

//[assembly: AssemblyVersionAttribute("4.3.2.1")]

namespace Day2Lap
{
    public class Userorder
    {
        User[] users;

        public Userorder
        {
            users[0] = new {Name="Ahmed", ID=10};
        }
        public User GetUser()
        {
            return users[0];
        }
    }
}
