using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWorkGit.DbLayer
{
    public class UserInRole
    {
        [Key]
        public int UserInRoleId { get; set; }

        public int UserId { get; set; }

        public int RoleId { get; set; }

        [Required]
        [Column(TypeName = "Date")]
        public DateTime HireDate { get; set; }
    }
}
