///// Data type
//// Numbers

// Integer
int whole = 10;
Console.WriteLine($"Integer: {whole}");

// Float (Single)
float precision = 5.0001F;
Console.WriteLine($"Float: {precision}");

// Double
double temperature = 32.6D;
Console.WriteLine($"Double: {temperature}");

// Decimal
decimal itemValue = 1999.99M;
Console.WriteLine($"Decimal: {itemValue}");

//// Text

// String
string firstName = "Enrico";
Console.WriteLine($"String: {firstName}");

// Char
char grade = 'A';
Console.WriteLine($"Char: {grade}");

//// Converting strings to numbers
Console.WriteLine(@"
---------------------------------------------
Converting strings to numbers:");

// Int
string textAge = "26";
int age = Convert.ToInt32(textAge);
Console.WriteLine(age);

// Float
string textPi = "3,141592";
float pi = Convert.ToSingle(textPi);
Console.WriteLine(pi);

// Double
string textHeight = "1,81";
double height = Convert.ToDouble(textHeight);
Console.WriteLine(height);

// Decimal
string textCost = "1999,99";
decimal cost = Convert.ToDecimal(textCost);
Console.WriteLine(cost);
