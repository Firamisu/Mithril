namespace Mithril.Models
{
    public class Exercise
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float EffortPointsPerMinute { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string DifficultyLevel { get; set; }
        public string MuscleGroup { get; set; }
        public float ApproxTimeToDoOneRep { get; set; }


        public ICollection<ExerciseLog> ExerciseLogs { get; set; }


        public Exercise()
        {
        }
    }

   
}
