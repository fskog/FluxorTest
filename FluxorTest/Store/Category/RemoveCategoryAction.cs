using Blazor.Fluxor;
using FluxorTest.Store.Timer;
using System;

namespace FluxorTest.Store.Category
{
	public class RemoveCategoryAction
	{
		public Guid systemId;
		public RemoveCategoryAction(Guid systemId)
		{
			this.systemId = systemId;
		}
	}

	namespace RemoveCategory
	{
		public static class Reducers
		{
			[ReducerMethod]
			public static CategoryState ReduceRemoveCategoryAction(CategoryState state, RemoveCategoryAction action)
			{
				var categories = state.Categories;
				categories.Remove(categories.Find(x => x.SystemId == action.systemId));
				return new CategoryState(categories);
			}
		}
	}

}
