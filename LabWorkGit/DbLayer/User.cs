using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWorkGit.DbLayer
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [StringLength(20)]
        public string Email { get; set; }
        [Required]
        [StringLength(20)]
        public string UserName { get; set; }
        [Required]
        [Column(TypeName ="Date")]
        public DateTime DateBirthday { get; set; }
        
        public int? JobTitleId { get; set; }
    }
}
