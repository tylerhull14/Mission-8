using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public List<Category> Categories => _context.Categories.ToList();

        public void AddActivity(Activity activity) 
        {
            _context.Activities.Add(activity);
            _context.SaveChanges();
        }

        public void EditActivity(Activity activity) 
        {
            _context.Update(activity);
            _context.SaveChanges();
        }

        public void DeleteActivity(Activity activity) 
        {
            _context.Activities.Remove(activity);
            _context.SaveChanges();
        }

        public Activity GetActivity(int id) 
        {
            return _context.Activities.FirstOrDefault(x => x.ActivityId == id);
        }

        public List<Activity> GetAllActivities()
        {
            return _context.Activities
                .Include(t => t.Category).ToList();
        }

    }
}