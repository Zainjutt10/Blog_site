using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment03.Models
{
    static public class LoginRepo
    {
        static public List<Login> lg = new List<Login>();
        static LoginRepo()
        {
            lg.Add(new Login { id=1,email="z@1.com",Name = "Zain", Password = "1234",admin=true });
            lg.Add(new Login { id=2, email = "a@1.com",Name = "Ali", Password = "12345",admin=false });
            lg.Add(new Login { id=3, email = "d@1.com",Name = "Dogar", Password = "123456" ,admin=false});
        }
        
    }
}
