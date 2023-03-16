using IceCreamShop;

Case menu = new Case();
List<Flavor> availableFlavors = menu.Flavors;
List<Cone> availableCones = menu.Cones;


// TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
//  field.

/*FlavorComparer comparer = new FlavorComparer();
foreach(Flavor flavor in availableFlavors)
{
    Console.WriteLine(flavor.Name);

}
availableFlavors.Sort(comparer);
Console.WriteLine(Environment.NewLine);
foreach(Flavor flavors in availableFlavors)
{
    Console.WriteLine(flavors.Name);
}
Console.WriteLine(Environment.NewLine);


// TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
//  field.
foreach (Cone cone in availableCones)
{
    Console.WriteLine($"{cone.Name}: ${cone.Cost}");
}
availableCones.Sort(new ConeComparer());
Console.WriteLine(Environment.NewLine);
foreach (Cone cone in availableCones)
{
    Console.WriteLine($"{cone.Name}: ${cone.Cost}");
}*/
// TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.

Console.WriteLine(Environment.NewLine);
foreach (Flavor flavor in availableFlavors)
{
    foreach(string allergen in flavor.Allergens)
    {
        Console.WriteLine($"{flavor.Name}: {allergen}");
    }
    

}

availableFlavors.Sort(new FlavorComparer());
Console.WriteLine(Environment.NewLine);
foreach (Flavor flavor in availableFlavors)
{
    Console.WriteLine(flavor.Allergens.Count);

}




