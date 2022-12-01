using csharp_oop_shop_2;

Cibo prodotto1 = new Cibo("Supplì", false, false, "Palla di riso al sugo panata", 1.50, 22);
Liquido prodotto2 = new Liquido("Acqua", true, false, "Acqua", 1.50, 22);
Liquido prodotto3 = new Liquido("Monster", true, true, "Bibita energetica dolce", 2.50, 22);
Cibo prodotto4 = new Cibo("Saitan", true, false, "Fungo", 10, 22);
Cibo prodotto5 = new Cibo("Pizza Regina", false, true, "Pizza surgelata", 3.00, 22);
Liquido prodotto6 = new Liquido("Ace spray", false, false, "Sgrassatore", 3.00, 22);

List<Prodotto> list = new List<Prodotto>() { prodotto1, prodotto2, prodotto3, prodotto4, prodotto5, prodotto6 };

prodotto1.StampaProdotto();
Console.WriteLine();

prodotto2.StampaProdotto();
Console.WriteLine();

prodotto3.StampaProdotto();
Console.WriteLine();

prodotto4.StampaProdotto();
Console.WriteLine();

prodotto5.StampaProdotto();
Console.WriteLine();

prodotto6.StampaProdotto();