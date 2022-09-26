using OOP1;

product product1 = new product();
product1.Id = 1;
product1.CategoryId = 2;
product1.ProductName = "Masa";
product1.UnitPrice = 500;
product1.UnıtsInStock = 3;

product product2 = new product { Id = 2, CategoryId = 5, UnıtsInStock = 5, ProductName = "Kalem", UnitPrice = 35 };

ProductManager productManager = new ProductManager();
productManager.Add(product1);

