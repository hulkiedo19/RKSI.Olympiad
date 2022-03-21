using RKSI.Olympiad.Client.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKSI.Olympiad.Client.ViewModels
{
    public class UserWindowViewModel : ViewModel
    {
        private List<Treaty> _escapeTreaties;

        public List<Treaty> EscapeTreaties 
        { 
            get => _escapeTreaties;
            set
            {
                Set(ref _escapeTreaties, value, nameof(EscapeTreaties));
            }
        }

        public UserWindowViewModel()
        {
            using(var dbContext = new DatabaseEntities())
            {
                var today = DateTime.Today;

                EscapeTreaties = dbContext.Treaties
                    .Include(nameof(Treaty.Client))
                    //.Where(t => DbFunctions.TruncateTime(t.DateEscape) == today)                    
                    .ToList();                    
            }
        }
    }
}
