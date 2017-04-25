using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace ISCAP.Models
{
    public class Slot
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int slotId { get; set; }
        [Required]
        [Display(Name = "Conference")]
            public string conference { get; set; }
            [Required]
            [Display(Name = "Title")]
            public string title { get; set; }
            [Required]
            [Display(Name = "Authors")]
            public string authors { get; set; }
            [Required]
            [Display(Name = "Slot Time")]
            public int slotTime { get; set; }
            public int? roomId { get; set; }
            public int? slotBlockId { get; set; }

            [ForeignKey("panelId")]
            [Display(Name = "Panels")]
            public int? panelId { get; set; }

            [ForeignKey("eventID")]
            [Display(Name = "Events")]
            public int? eventID { get; set; }

        [ForeignKey("workShopId")]
        [Display(Name = "Workshops")]
        public int? workShopId { get; set; }

            public int SaveDetails()
            {
                SqlConnection con = new SqlConnection(GetConString.ConString());
                string query = "INSERT INTO Slot(title, conference, authors, slotTime) values ('" + title + "','" + conference + "','" + authors + "','" + slotTime + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();
                return i;
            }
        }
    }

