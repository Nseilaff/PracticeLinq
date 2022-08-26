


var newList = new List<string>();

newList.Add("Assassins Creed");
newList.Add("StarCraft");
newList.Add("Warcraft");
newList.Add("Gears Of War");
newList.Add("Halo");
newList.Add("Halo Reach");


newList.OrderBy(x => x.Length).ToList().ForEach(Console.WriteLine);
