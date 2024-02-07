using System.ComponentModel.DataAnnotations;

namespace ParkNet_JoaoMendes.Data.Entities
{
    public class Customer
    {
        // Properties
        [Key]
        public int CostumerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
       
        [Required]
        public string DriversLicense { get; set; }
       
        [Required]
        public string CreditCard { get; set; }

        public int VehicleId { get; set; }
     //Falta criar o resto das entidades  
    }
}
