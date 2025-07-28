using System.ComponentModel.DataAnnotations;

namespace AkilliFitApp.Domain.Entities
{
    public abstract class EgzersizBilgi
    {
        public int Id { get; private set; }
        public int EgzersizProgramId { get; set; }
        public EgzersizProgram EgzersizProgram { get; set; } = null!;
        public int EgzersizId { get; set; }
        public Egzersiz Egzersiz { get; set; } = null!;
        public int EgzersizNotId { get; set; }
        public required EgzersizNot EgzersizNot { get; set; }
    }
}
