using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWorkGit.DbLayer
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        [Required]
        [StringLength(20)]
        public string RoleName { get; set; }
       
        [StringLength(200)]
        public string Description { get; set; }
    }
}
