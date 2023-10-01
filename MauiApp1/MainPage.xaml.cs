using Microsoft.Maui.Controls;
using System;
using System.Collections.ObjectModel;
namespace MauiApp1
{    
        public partial class MainPage : ContentPage
        {
            private ObservableCollection<Product> products;

            public MainPage()
            {
                InitializeComponent();

                // Ініціалізація списку товарів
                products = new ObservableCollection<Product>
            {
                new GroceryProduct
                {
                    Price = 10.99,
                    CountryOfOrigin = "USA",
                    Name = "Apples",
                    PackagingDate = DateTime.Now.Date,
                    Description = "Fresh red apples",
                    ExpiryPeriod = TimeSpan.FromDays(14),
                    Quantity = 10,
                    UnitOfMeasurement = "kg"
                },
                new Book
                {
                    Price = 29.99,
                    CountryOfOrigin = "UK",
                    Name = "The Great Gatsby",
                    PackagingDate = DateTime.Now.Date,
                    Description = "Classic novel",
                    PageCount = 180,
                    Publisher = "Scribner",
                    Authors = new System.Collections.Generic.List<string> { "F. Scott Fitzgerald" }
                }
            };

                // Встановлення джерела даних для ListView
                productListView.ItemsSource = products;
            }

            // Обробник події для кнопки "Додати товар"
            private void OnAddProductClicked(object sender, EventArgs e)
            {
                // Додавання нового продукту до списку
                products.Add(new GroceryProduct
                {
                    Price = 5.99,
                    CountryOfOrigin = "Canada",
                    Name = "Bananas",
                    PackagingDate = DateTime.Now.Date,
                    Description = "Fresh yellow bananas",
                    ExpiryPeriod = TimeSpan.FromDays(7),
                    Quantity = 15,
                    UnitOfMeasurement = "pieces"
                });
            }

            // Обробник події для кнопки "Видалити товар"
            private void OnRemoveProductClicked(object sender, EventArgs e)
            {
                // Видалення виділеного продукту зі списку
                if (productListView.SelectedItem != null)
                {
                    products.Remove(productListView.SelectedItem as Product);
                }
            }
        }
}