using IceCreamShop;

Case menu = new Case();
List<Flavor> availableFlavors = menu.Flavors;
List<Cone> availableCones = menu.Cones;

// TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
//  field.
//FlavorComparer superGood = new FlavorComparer();

//foreach (Flavor flav in availableFlavors)
//{
//    Console.WriteLine(flav.Name);
//}

availableFlavors.Sort(new FlavorComparer());
//availableFlavors.Sort(superGood);**This is the same as above line and with the above line we can do without declaring and initializing the Comparer Object named superGood.
Console.WriteLine(">>>>>\n");
foreach (Flavor flav in availableFlavors)
{
    Console.WriteLine(flav.Name);
}
Console.WriteLine("********************\n");
// TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
//  field.
//foreach(Cone cone in availableCones)
//{
//    Console.WriteLine($"{cone.Name}: {cone.Cost}");
//}
//Console.WriteLine(">>>>>>>>>>\n");
availableCones.Sort(new ConeComparer());
foreach(Cone cone in availableCones)
{
    Console.WriteLine($"{cone.Name}: {cone.Cost}");
}
// TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.
Console.WriteLine("********************\n");

foreach (Flavor flav in availableFlavors)
{
    Console.WriteLine($"{flav.Name} Allergens: {flav.Allergens.Count}");
}
Console.WriteLine("********************\n");

