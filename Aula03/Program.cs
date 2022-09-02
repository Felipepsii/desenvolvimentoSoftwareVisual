using System;
using System.IO;

namespace Aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario p = new Usuario("Felitops", "batatop");
            Usuario q = new Usuario("Pepinos", "pokemon38");
            Usuario d = new Usuario("Pepinos", "pokemon38");
            UserBase myBase = new UserBase("userbase.txt");
            myBase.AddUser(p);
            myBase.AddUser(q);
            myBase.AddUser(d);
            myBase.Save();


        }
    }
}
