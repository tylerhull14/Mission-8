namespace Mission_8.Models
{
    public class EFActivityRepository : IActivityRepository
    {
        private ActivityContext _context;
        
        public EFActivityRepository(ActivityContext temp)
        {
            _context = temp;
        }
        
        public List<Activity> Activities => _context.Activities.ToList();
    }
}