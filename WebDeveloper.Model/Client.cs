using System;
using System.ComponentModel.DataAnnotations;
using WebDeveloper;
using WebDeveloper.Resources;

namespace WebDeveloper.Model
{
    public class Client
    {
        [Display(Name = "Client_Id", ResourceType = typeof(Resource))]
        public int ID { get; set; }

        [Display(Name="Client_Name", ResourceType =typeof(Resource))]
        [Required(ErrorMessage="This field is required")]
        public string Name { get; set; }
        [Display(Name = "Client_LastName", ResourceType =typeof(Resource))]
        [Required(ErrorMessage = "The Last Name is required")]
        public string LastName { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? DateCreation { get; set; }
    }
}
