using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace SampleCore.Core.Model
{
    public class Person
    {
        
        public int Id { get; set; }
      
        public string firstName { get; set; }
       
        public string middleName { get; set; }
       
        public string lastName { get; set; }
       
        public string course { get; set; }
       
        public string gender { get; set; }
       
        public string phone { get; set; }
        
        public string address { get; set; }
        
        public string email { get; set; }


        
        public string password { get; set; }
        
        public string retypePassword { get; set; }
        
        public bool? IsDeleted { get; set; }
        public DateTime? CreatedTimeStamp { get; set; }
        public DateTime? UpdatedTimeStamp { get; set; }
    }
}
