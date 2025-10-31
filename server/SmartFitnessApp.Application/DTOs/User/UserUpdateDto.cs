using System;

namespace SmartFitnessApp.Application.DTOs.User
{
    public class UserUpdateDto
    {
        public string Name { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateOnly BirthDate { get; set; }
        public string Gender { get; set; } = null!;
        public double Weight { get; set; }
        public double TargetWeight { get; set; }
        public int ActivityLevel { get; set; }
        public string? ProfilePictureUrl { get; set; }
    }
}
