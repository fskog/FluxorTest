using Blazor.Fluxor;
using FluxorTest.Store.Timer;
using System;

namespace FluxorTest.Store.Category
{
	public class AddCategoryAction
	{
		public string categoryName;
		public AddCategoryAction(string name)
		{
			categoryName = name;
		}
	}

	namespace AddCategory
	{
		public static class Reducers
		{
			[ReducerMethod]
			public static CategoryState ReduceAddCategoryAction(CategoryState state, AddCategoryAction action)
			{
				var categories = state.Categories;
				categories.Add(new Models.Category(action.categoryName));
				return new CategoryState(categories);
			}
		}
	}

}
