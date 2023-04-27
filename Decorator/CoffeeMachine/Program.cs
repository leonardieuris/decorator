using Decorator;



var espresso = new Coffee();
var macchiato = new MilkDecorator(espresso);
var macchiatoConCioccolato= new ChoccolateDecorator(macchiato);
var espressoConCioccolato = new ChoccolateDecorator(espresso);


Console.WriteLine($"{espresso.GetDescription()} - {espresso.GetCost()}");
Console.WriteLine($"{macchiato.GetDescription()} - {macchiato.GetCost()}");
Console.WriteLine($"{macchiatoConCioccolato.GetDescription()} - {macchiatoConCioccolato.GetCost()}");
Console.WriteLine($"{espressoConCioccolato.GetDescription()} - {espressoConCioccolato.GetCost()}");


/*
1 - Espresso
2 - Latte
3 - cioccolato


1 Espresso
1,2 Macchiato
1,2,3 Macchiato con cioccolato
1,3 Espresso con cioccolato
*/

