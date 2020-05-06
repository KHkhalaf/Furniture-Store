using FurnitureStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FurnitureStore.Services
{
    public static class DataStore
    {
        static DataStore()
        {
            Items = new List<Item>();
            // Add items of chair
            Items.Add(new Item()
            {
                Name = "Mammut",
                Description = "The robust and lightweight MAMMUT series withstands the elements of weather and wild imaginative play. Perfect for the outdoors and easy to clean when it’s time to move indoors.",
                InStock = true,
                Category = "Chairs",
                Price = 17.50M,
                Variations = new List<Variation>()
                {
                    new Variation () { ColorHex="#0000FF", Image="mammut_blue" },
                    new Variation () { ColorHex="#ffC0CB", Image="mammut_pink" },
                    new Variation () { ColorHex="#FF0000", Image="mammut_red" },
                }
            });

            Items.Add(new Item()
            {
                Name = "Mammut2",
                Description = "The robust and lightweight MAMMUT series withstands the elements of weather and wild imaginative play. Perfect for the outdoors and easy to clean when it’s time to move indoors.",
                InStock = true,
                Category = "Chairs",
                Price = 17.50M,
                Variations = new List<Variation>()
                {
                    new Variation () { ColorHex="#ffC0CB", Image="mammut_pink" },
                    new Variation () { ColorHex="#0000FF", Image="mammut_blue" },
                    new Variation () { ColorHex="#FF0000", Image="mammut_red" },
                }
            });

            Items.Add(new Item()
            {
                Name = "Poang",
                Description = "Layer-glued bent birch frame gives comfortable resilience. The high back gives good support for your neck.",
                InStock = false,
                Price = 119.00M,
                Category = "Chairs",
                Variations = new List<Variation>()
                {
                    new Variation () { ColorHex="#FF0000", Image="poang_red" },
                    new Variation () { ColorHex="#E1C699", Image="poang_beige" },
                    new Variation () { ColorHex="#36454F", Image="poang_charcoal" },
                    new Variation () { ColorHex="#00FF00", Image="poang_green" },
                }
            });

            // Add items of sofa

            Items.Add(new Item()
            {
                Name = "Sofa1",
                Description = "The robust and lightweight MAMMUT series withstands the elements of weather and wild imaginative play. Perfect for the outdoors and easy to clean when it’s time to move indoors.",
                InStock = true,
                Category = "Sofas",
                Price = 17.50M,
                Variations = new List<Variation>()
                {
                    new Variation () { ColorHex="#ffead2", Image="sofa1" },
                    new Variation () { ColorHex="#c9dd5a", Image="sofa2" },
                    new Variation () { ColorHex="#4b4c47", Image="sofa3" },
                }
            });

            Items.Add(new Item()
            {
                Name = "Sofa2",
                Description = "The robust and lightweight MAMMUT series withstands the elements of weather and wild imaginative play. Perfect for the outdoors and easy to clean when it’s time to move indoors.",
                InStock = true,
                Category = "Sofas",
                Price = 17.50M,
                Variations = new List<Variation>()
                {
                    new Variation () { ColorHex="#a0b1d9", Image="sofa4" },
                    new Variation () { ColorHex="#ef5c54", Image="sofa5" },
                    new Variation () { ColorHex="#eecfb5", Image="sofa6" },
                }
            });

            Items.Add(new Item()
            {
                Name = "Sofa3",
                Description = "Layer-glued bent birch frame gives comfortable resilience. The high back gives good support for your neck.",
                InStock = false,
                Price = 119.00M,
                Category = "Sofas",
                Variations = new List<Variation>()
                {
                    new Variation () { ColorHex="#d9711b", Image="sofa7" },
                    new Variation () { ColorHex="#ece4de", Image="sofa8" },
                }
            });

            // Add items of table

            Items.Add(new Item()
            {
                Name = "Table1",
                Description = "The robust and lightweight MAMMUT series withstands the elements of weather and wild imaginative play. Perfect for the outdoors and easy to clean when it’s time to move indoors.",
                InStock = false,
                Category = "Tables",
                Price = 10.50M,
                Variations = new List<Variation>()
                {
                    new Variation () { ColorHex="#767788", Image="table1" },
                    new Variation () { ColorHex="#e1d2c4", Image="table2" },
                    new Variation () { ColorHex="#e1ab7b", Image="table3" },
                }
            });

            Items.Add(new Item()
            {
                Name = "Table2",
                Description = "The robust and lightweight MAMMUT series withstands the elements of weather and wild imaginative play. Perfect for the outdoors and easy to clean when it’s time to move indoors.",
                InStock = true,
                Category = "Tables",
                Price = 17.50M,
                Variations = new List<Variation>()
                {
                    new Variation () { ColorHex="#f6c59a", Image="table4" },
                    new Variation () { ColorHex="#f6a35b", Image="table5" },
                    new Variation () { ColorHex="#e6cf82", Image="table6" },
                }
            });

            Items.Add(new Item()
            {
                Name = "Table3",
                Description = "Layer-glued bent birch frame gives comfortable resilience. The high back gives good support for your neck.",
                InStock = false,
                Price = 119.00M,
                Category = "Tables",
                Variations = new List<Variation>()
                {
                    new Variation () { ColorHex="#81420b", Image="table7" },
                    new Variation () { ColorHex="#e8a56a", Image="table8" },
                }
            });

            // Add items of lamp

            Items.Add(new Item()
            {
                Name = "Lamp1",
                Description = "The robust and lightweight MAMMUT series withstands the elements of weather and wild imaginative play. Perfect for the outdoors and easy to clean when it’s time to move indoors.",
                InStock = false,
                Category = "Lamps",
                Price = 10.50M,
                Variations = new List<Variation>()
                {
                    new Variation () { ColorHex="#65b788", Image="lamp1" },
                    new Variation () { ColorHex="#d4e7dc", Image="lamp2" },
                    new Variation () { ColorHex="#dec5b4", Image="lamp3" },
                }
            });

            Items.Add(new Item()
            {
                Name = "Lamp2",
                Description = "The robust and lightweight MAMMUT series withstands the elements of weather and wild imaginative play. Perfect for the outdoors and easy to clean when it’s time to move indoors.",
                InStock = true,
                Category = "Lamps",
                Price = 17.50M,
                Variations = new List<Variation>()
                {
                    new Variation () { ColorHex="#8f7665", Image="lamp6" },
                    new Variation () { ColorHex="#a96ea2", Image="lamp7" },
                    new Variation () { ColorHex="#f3cd6f", Image="lamp8" },
                }
            });

            Items.Add(new Item()
            {
                Name = "Lamp3",
                Description = "Layer-glued bent birch frame gives comfortable resilience. The high back gives good support for your neck.",
                InStock = false,
                Price = 119.00M,
                Category = "Lamps",
                Variations = new List<Variation>()
                {
                    new Variation () { ColorHex="#81420b", Image="lamp4" },
                    new Variation () { ColorHex="#e8a56a", Image="lamp5" },
                }
            });
        }

        public static List<Item> Items;

        public static List<Category> GetCategories()
        {
            var categories = new List<Category>()
            {
                new Category() {Name = "Chairs"},
                new Category() {Name = "Sofas"},
                new Category() {Name = "Tables"},
                new Category() {Name = "Lamps"},
            };
            return categories;
        }

        internal static IEnumerable<Item> GetItemsForCategory(string obj)
        {
            return Items.Where(n => n.Category == obj);
        }

        internal static IEnumerable<Item> GetItemsForCategory(Category selectedCategory)
        {
            var selectedItems = new List<Item>();
            foreach (var item in Items)
            {
                selectedItems.Add(item);
            }

            return selectedItems;
        }
    }

}
