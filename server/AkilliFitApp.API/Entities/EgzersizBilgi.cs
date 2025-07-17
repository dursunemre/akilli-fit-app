using System.ComponentModel.DataAnnotations;

namespace AkilliFitApp.API.Entities
{
    public abstract class EgzersizBilgi
    {
        [Key]
        public virtual int Id { get; set; }
        
        [Required]
        public abstract string Ad {  get; } 
    }
}
