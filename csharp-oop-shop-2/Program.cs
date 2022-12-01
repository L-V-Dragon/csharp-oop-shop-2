using csharp_oop_shop_2;

Prodotto prodotto1 = new Prodotto("Supplì", "Palla di riso al sugo panata", 1.50, 22);
Prodotto prodotto2 = new Prodotto("Assorbenti", "Panno assorbente per perdite mestruali", 3.50, 5);
Prodotto prodotto3 = new Prodotto("Acqua", "Acqua", 50, 10);

List<Prodotto> list = new List<Prodotto>() { prodotto1, prodotto2, prodotto3 };

prodotto1.StampaProdotto();
Console.WriteLine();

prodotto2.StampaProdotto();
Console.WriteLine();

prodotto3.StampaProdotto();

