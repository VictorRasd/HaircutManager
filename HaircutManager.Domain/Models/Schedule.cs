namespace HaircutManager.Domain.Models
{
    public class Schedule
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid ProfessionalId { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public User Professional { get; set; }
    }
}
