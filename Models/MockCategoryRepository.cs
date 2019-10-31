using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class MockCategoryRepository: ICategoryRepository
    {
        public IEnumerable<Category> Categories =>
            new List<Category>
            { 
                new Category{CategoryId=1, CategoryName="Fruit pies", Description="All-fruit"},
                new Category{CategoryId=2, CategoryName="Cheese", Description="Bread"}
            };
    }
}
