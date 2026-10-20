Vehicle car1 = new Vehicle("Bil1", 75, 20);

Console.WriteLine($"Startladdning: {car1.Percent}%");

car1.Charge(30);
Console.WriteLine($"Efter 30 kWh: {car1.Percent}%");

car1.Charge(50);
Console.WriteLine($"Efter ytterligare 50 kWh: {car1.Percent}%");