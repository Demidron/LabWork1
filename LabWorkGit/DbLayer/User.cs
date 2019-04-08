﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWorkGit.DbLayer
{
    public class User
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public DateTime DateBirthday { get; set; }
        public int? JobTitleId { get; set; }
    }
}