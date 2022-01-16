using Step_EShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Step_EShop.FakeDB.Repositories.Categories.Abstract
{
    public interface ICategoryRepository
    {
        Category GetById(int id);
        List<Category> GetCategories();
        Category Add(Category category);
        int Update(Category category);
        void Delete(int id);
    }
}
