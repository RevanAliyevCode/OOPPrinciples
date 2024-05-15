using Animals;

Cat newCat = new("mirmir", 5, "unknown", "sari");
Dog newDog = new("Worlds destroyer", 6, "pitbull", "black");

Console.WriteLine($"{newCat.MakeSound()}, {newDog.MakeSound()}");