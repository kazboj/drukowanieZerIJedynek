Random random = new Random();
for (int i = 0; i < 8 * 1024 * 1024; i++)
    Console.Write(random.Next(0, 2));
