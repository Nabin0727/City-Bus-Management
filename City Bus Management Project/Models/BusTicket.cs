
using System.ComponentModel.DataAnnotations;

namespace City_Bus_Management_Project.Models
{
    public class BusTicket
    {
        [Required]
        public string Destination { get; set; }

        [Required]
        public string BusPoint { get; set; }

        [Required]
        public string Date { get; set; }

        [Required]
        public string Route { get; set; }
    }

    public enum Destination
    {
       Sundahra, Chabahil, Chakrapat, Satdobato, Baneshowr, Kalanki, Koteshowr, Bhaktapur
    }

    public enum BusPoint
    {   
        BusPark, Gabgabu, Budaneelkantha, Sitapaila, Banasthali
       
    }

    public enum Route
    {
        RouteNo1, RouteNo2, RouteNo3, RouteNo4, RouteNo5, RouteNo6, RouteNo7,
        RouteNo8, RouteNo9, RouteNo10, RouteNo11, RouteNo12, RouteNo13, RouteNo14
    }
}
