using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Adminwebapi.Models
{
    public class Admin
    {
        [Key]
        public int LoginId{get;set;}

        [Key]
        public int Password{get;set;}


    }
}