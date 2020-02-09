using Blazor.Fluxor;
using System.Collections.Generic;

namespace FluxorTest.Store.Category
{
	public class CategoryFeature : Feature<CategoryState>
	{
		public override string GetName() => "Category";
		protected override CategoryState GetInitialState()
		{
			List<Models.Category> categories = new List<Models.Category>
			{
				new Models.Category("Cooking"),
				new Models.Category("Workout"),
				new Models.Category("Movies" ),
				new Models.Category("Work")
			};
			return new CategoryState(categories);
		}
	}
}
