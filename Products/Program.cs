// See https://aka.ms/new-console-template for more information

using Products;


Electoncis elec = new("tv", "televisior", 1, "plastic", 100m);
Clothes clote = new("T-shirt", "Newyorker t-shirt", 2, "3xl", 50m);
Clothes clote1 = new("T-shirt", "Newyorker t-shirt", 3, "3xl", 50m);
Orders orders = new Orders();

orders.AddProduct(elec);
orders.AddProduct(clote);


orders.RemoveProduct(clote1);


Console.WriteLine(orders.GetTotalAmount());

orders.GetProductsDetails();