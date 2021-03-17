using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QQ2020
{
    class User
    {
        private static string name;
        private static string email;
        private static Image image;


        public static string Name { get => name; set => name = value; }
        public static string Email { get => email; set => email = value; }
        public static Image Image { get => image; set => image = value; }
    }
}
