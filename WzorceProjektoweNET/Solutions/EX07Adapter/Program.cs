using EX07Adapter;

Adult adult = new Adult();
FakeAdult fakeAdult = new FakeAdult();

Console.WriteLine("Check age");
int age1 = Console.ReadLine() is string input1 && int.TryParse(input1, out int result1) ? result1 : 0;
Console.WriteLine($"Is {age1} an adult? {adult.IsAdult(age1)}");
Console.WriteLine($"Is {age1} an adult with FakeAdult check? {fakeAdult.IsAdult(age1)}");