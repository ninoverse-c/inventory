using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public static class UserSession
    {
        public static int UserId { get; private set; }
        public static string Username { get; private set; } = "";
        public static string FullName { get; private set; } = "";
        public static string Role { get; private set; } = "";

        public static void Start(int id, string username, string fullName, string role)
        {
            UserId = id;
            Username = username;
            FullName = fullName;
            Role = role;
        }

        public static void Clear()
        {
            UserId = 0;
            Username = "";
            FullName = "";
            Role = "";
        }
    }
}
