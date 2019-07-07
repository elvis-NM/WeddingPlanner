using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace WeddingPlanner.Models
{
    public class Wedding
    {
        [Key]
        public int WeddingId { get; set; }
        [Required]
        [MinLength(4, ErrorMessage = " must be 4 or more characters")]
        public string Groom { get; set; }
        [Required]
        [MinLength(4, ErrorMessage = " must be 4 or more characters")]
        public string Bride { get; set; }
        // Must Be Future Date
        [DataType(DataType.Date)]
        [Required]


        public DateTime Date { get; set; } = DateTime.Now;
        [Required]

        public string Venue { get; set; }

        public int UserId { get; set; }

        public User Planner { get; set; }
        public List<Response> Responses { get; set; }




    }
    public class Response
    {
        [Key]
        public int ResponseId { get; set; }
        public int WeddingId { get; set; }
        public int UserId { get; set; }
        public User Guest { get; set; }



    }

}