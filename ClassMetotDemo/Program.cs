using ClassMetotDemo;

Musteri musteri1 = new Musteri();
musteri1.Adi = "Güven";
musteri1.Soyadi = "Özcan";
musteri1.Yas = 23;

Musteri musteri2 = new Musteri();
musteri2.Adi = "X";
musteri2.Soyadi = "Y";
musteri2.Yas = 25;

Musteri musteri3 = new Musteri();
musteri3.Adi = "A";
musteri3.Soyadi = "B";
musteri3.Yas = 14;

Musteri musteri4 = new Musteri();   
musteri4.Adi = "C";
musteri4.Soyadi = "D";
musteri4.Yas = 10;

MusteriManager musteriManager = new MusteriManager();
musteriManager.MusteriEkle(musteri1);
musteriManager.MusteriEkle(musteri2);
musteriManager.MusteriSil(musteri3);
musteriManager.Listeleme(musteri4);