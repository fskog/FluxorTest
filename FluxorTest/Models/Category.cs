using System;

namespace FluxorTest.Models
{
    public class Category
    {
        public Guid SystemId { get; private set; }
        public string Name { get; set; }

        public Category(string name = "New category")
        {
            Name = name;
            SystemId = Guid.NewGuid();
        }

        public static Category Empty
        {
            get
            {
                return new Category() { Name = "no category", SystemId = Guid.Empty };

            }
        }

        public void SetName(string name)
        {
            Name = name;
        }

    }
}