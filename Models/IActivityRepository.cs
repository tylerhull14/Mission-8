namespace Mission_8.Models
{
    public interface IActivityRepository
    {
        List<Activity> Activities { get; }
        List<Category> Categories { get; }

        public void AddActivity (Activity activity);
        public void EditActivity (Activity activity);
        public void DeleteActivity (Activity activity);
        Activity GetActivity (int id);
        List<Activity> GetAllActivities ();
    }
}