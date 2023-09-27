Random dice = new();
// int roll1 = dice.Next();
// int roll2 = dice.Next(101);
// int roll3 = dice.Next(50, 101);

// Console.WriteLine($"First roll: {roll1}");
// Console.WriteLine($"Second roll: {roll2}");
// Console.WriteLine($"Third roll: {roll3}");

int firstValue = 500;
int secondValue = 600;
int largerValue;
largerValue = Math.Max(firstValue, secondValue);

// Console.WriteLine(largerValue);

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//     if ((roll1 == roll2) && (roll2 == roll3))
//     {
//         Console.WriteLine("You rolled triples! +6 bonus to total!");
//         total += 6;
//     }
//     else
//     {
//         Console.WriteLine("You rolled doubles! +2 bonus to total!");
//         total += 2;
//     }
// }

// if (total >= 16)
// {
//     Console.WriteLine("YOU WIN A CAR!!!");
// }
// else if (total >= 10)
// {
//     Console.WriteLine("YOU WIN A Laptop");
// }
// else if (total >= 7)
// {
//     Console.WriteLine("You won a trip for 2");
// }
// else
// {
//     Console.WriteLine("You won a kitten");
// }

// Console.WriteLine($"Dice roll: {roll1}, {roll2}, {roll3} for a total of {total}");

Random random = new();
int daysUntilExpiration = random.Next(12);
// int discountPercentage = 0;

// if (daysUntilExpiration == 0)
// {
//     Console.WriteLine("Your subscription has expired.");
// }
// else if (daysUntilExpiration == 1)
// {
//     discountPercentage = 20;
//     Console.WriteLine($@"Your subscription expires within a day!
// Renew now and save {discountPercentage}%!");
// }
// else if (daysUntilExpiration <= 5)
// {
//     discountPercentage = 10;
//     Console.WriteLine($@"Your subscription expires in {daysUntilExpiration} days.
// Renew now and save {discountPercentage}%!");
// }
// else if (daysUntilExpiration <= 10)
// {
//     Console.WriteLine("Your subscription will expire soon. Renew now!");
// }

//ARRAYS

// string[] fraudulentOrderIDs = new string[3];

// fraudulentOrderIDs[0] = "A123";
// fraudulentOrderIDs[1] = "B456";
// fraudulentOrderIDs[2] = "C789";
// // fraudulentOrderIDs[3] = "D000";

// string[] fraudulentOrderIDs = { "A123", "B456", "C789", "F123" };

// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// fraudulentOrderIDs[0] = "F000";

// Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

//FOREACH

// string[] names = { "Rowena", "Robin", "Bao" };
// foreach (string name in names)
// {
// Console.WriteLine(name);
// }

// int[] inventory = { 200, 450, 700, 175, 250 };
// int sum = 0;
// int bin = 0;
// foreach (int num in inventory)
// {
//     sum += num;
//     bin++;
//     Console.WriteLine($"Bin {bin} = {num} items (Running total: {sum})");
// }

// Console.WriteLine($"We have {sum} items in inventory.");

string[] fraudulentOrderIDs = {
    "B123",
    "C234",
    "A345",
    "C15",
    "B177",
    "G3003",
    "C235",
    "B179"
};

// foreach (string order in fraudulentOrderIDs)
// {
//     if (order.StartsWith("B"))
//     {
//         Console.WriteLine(order);
//     }
// }

// Random random = new Random();
// string[] orderIDs = new string[5];
// // Loop through each blank orderID
// for (int i = 0; i < orderIDs.Length; i++)
// {
//     // Get a random value that equates to ASCII letters A through E
//     int prefixValue = random.Next(65, 70);
//     // Convert the random value into a char, then a string
//     string prefix = Convert.ToChar(prefixValue).ToString();
//     // Create a random number, pad with zeroes
//     string suffix = random.Next(1, 1000).ToString("000");
//     // Combine the prefix and suffix together, then assign to current OrderID
//     orderIDs[i] = prefix + suffix;
// }
// // Print out each orderID
// foreach (var orderID in orderIDs)
// {
//     Console.WriteLine(orderID);
// }

/*
    The following code creates five random OrderIDs
    to test the fraud detection process.  OrderIDs 
    consist of a letter from A to E, and a three
    digit number. Ex. A123.
*/
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");

    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}

/*The following code converts a string to an array of the characters, reverses the char,
counts the amount of 'o' appear in the new array, converts it back to a string and prints it out.*/
string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);
int letterCount = 0;

foreach (char i in message)
{
    if (i == 'o')
    {
        letterCount++;
    }
}
string newMessage = new String(message);

Console.WriteLine(message);
Console.WriteLine($"'o' appears {letterCount} times.");