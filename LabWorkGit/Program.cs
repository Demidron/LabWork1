using LabWorkGit.DbLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWorkGit
{
    class Program
    {
        static void Main(string[] args)
        {
            UserContext db = new UserContext();
            db.Users.AddRange(DataManager.users);
            db.SaveChanges();
            db.Roles.AddRange(DataManager.roles);
            db.SaveChanges();
            db.UserInRoles.AddRange(DataManager.userinroles);
            db.SaveChanges();
        }
    }
}
