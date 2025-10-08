// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static bool? RandomNullableBool() {
    Random rand = new Random();
    int value = rand.Next(0, 3); // Generates a number between 0 and 2
    if (value == 0) return true;
    else if (value == 1) return false;
    else return null;
}

bool? myNullableBool = RandomNullableBool();
if (myNullableBool is true) {
    Console.WriteLine("The value is true.");
} else if (myNullableBool is false) {
    Console.WriteLine("The value is false.");
} else {
    Console.WriteLine("The value is null.");
}

// Demonstrating pattern matching with nullable bools in a switch expression
string result = myNullableBool switch {
    true => "It's definitely true!",
    false => "It's definitely false!",
    null => "It's null!",
};
Console.WriteLine(result);

// Waiting for user input before closing the console window
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
//Console.ReadLine();
