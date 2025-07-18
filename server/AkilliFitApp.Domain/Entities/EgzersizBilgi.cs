using System.ComponentModel.DataAnnotations;

namespace AkilliFitApp.Domain.Entities
{
    public abstract class EgzersizBilgi
    {
        [Key]
        public virtual int Id { get; set; }

        public int EgzersizProgramId { get; set; }
        public EgzersizProgram EgzersizProgram { get; set; } = null!;

        [Required]
        public abstract string Ad {  get; } 
    }
}
