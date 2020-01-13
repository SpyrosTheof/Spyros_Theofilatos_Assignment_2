using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Spyros_Theofilatos_Assignment_2.Models
{
    public class Trainer
    {
        public int TrainerId { get; set; }

        
        public string Firstname { get; set; }

       
        public string Lastname { get; set; }

        public string Subject { get; set; }
        

    }
}