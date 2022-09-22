Product product1 = new Product();
product1.ÜrünAdi = "Bilgisayar";
product1.ÜrünKategorisi = "Teknoloji";
product1.ÜrünStok = 20;

Product product2 = new Product();   
product2.ÜrünAdi = "Telefon";
product2.ÜrünKategorisi = "Teknoloji";
product2.ÜrünStok = 10;

Product product3 = new Product();
product3.ÜrünAdi = "koltuk";
product3.ÜrünKategorisi = "Mobilya";
product3.ÜrünStok = 10;

Product[] products = new Product[] { product1, product2, product3};

for (int i = 0; i < products.Length; i++)
{
    Console.WriteLine("Ürün adı:" + products[i].ÜrünAdi +" "+ "Ürün Kategorisi:" + products[i].ÜrünKategorisi);

}
Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");

foreach (var product in products)
{
    Console.WriteLine(product.ÜrünAdi);
}
Console.WriteLine("yyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyy");
int a = 0;
while (a <products.Length)
{
    Console.WriteLine("Ürün adı : " + products[a].ÜrünAdi +" "+ "Ürün kategorisi: " + products[a].ÜrünKategorisi);
    a++;    

}


class Product
{
    public string ÜrünAdi { get; set; }
    public string ÜrünKategorisi { get; set; }
    public int ÜrünStok { get; set; }

}

