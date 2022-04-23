namespace Entities
{
    public class LessonVideo
    {
        public int ID { get; set; }
        public string Name { get; set; }=null!;
        public string? VideoUrl { get; set; }
        public TimeSpan VideoTime { get; set; }
        public int LessonId { get; set; }
    }
}