using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Data.Model
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Url { get; set; }
        public int? DislpayOrder { get; set; }
        [Required]
        public int GroupId { get; set; }
        [ForeignKey("GroupId")]
        public virtual MenuGroup MenuGroups { set; get; }
        public string Target { get; set; }
        [Required]
        public bool Status { get; set; }

    }
}
