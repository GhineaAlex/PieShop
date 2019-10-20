using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class MockPieRepository : IPieRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Pie> AllPies =>
            new List<Pie>
            {
                new Pie {PieId = 1, Name = "Cheese Pie", Price=15.95M, ShortDescription = "good", LongDescription = "very long desc", AllergyInformation = "none", CategoryId = 1}
            
            
            };
      
        public IEnumerable<Pie> PiesOfTheWeek { get;  }

        public Pie GetPieById(int pieId)
        {
            return AllPies.FirstOrDefault(p => p.PieId == pieId);
        }
    }
}
