using System;
using System.ComponentModel.DataAnnotations;


namespace WebDeveloper.Model
{
    public class Client
    {
        public int ID { get; set; }
        [Display(Name="First Name")]
        [Required(ErrorMessage="This field is required")]
        public string Name { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "The Last Name is required")]
        public string LastName { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? DateCreation { get; set; }
    }
}
