using HaircutManager.Domain.Enums;

namespace HaircutManager.Domain.Models
{
    public class Appointment
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid UserId { get; set; }          
        public Guid ProfessionalId { get; set; }  
        public Guid ServiceId { get; set; }
        public DateTime ScheduledAt { get; set; }
        public AppointmentStatus Status { get; set; } = AppointmentStatus.Scheduled;
        public User User { get; set; }
        public User Professional { get; set; }
        public Service Service { get; set; }
    }
}
