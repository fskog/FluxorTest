using FluxorTest.Models;
using System;
using System.Collections.Generic;

namespace FluxorTest.Store.Category
{
    public class CategoryState
    {
        public List<Models.Category> Categories { get; private set; }
        public CategoryState(List<Models.Category> categories)
        {
            Categories = categories;
        }

        public Models.Category GetCategory(Guid systemId)
        {
            var result = Categories.Find(x => x.SystemId.Equals(systemId));
            return result != null ? result : Models.Category.Empty;
        }

    }
}
