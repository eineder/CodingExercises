Console.WriteLine("Hello, this tool allows for validing passwords.");
const string prompt = "Please enter a password to have it checked.";
Console.WriteLine(prompt);

using var stream = Console.OpenStandardInput();
using var reader = new StreamReader(stream);

var validator = new PasswordValidator();

while (true)
{
    var line = await reader.ReadLineAsync();

    // Replace this line with putting out the outcome of the validation.
    Console.WriteLine($"Your password: {line}"); 

    Console.WriteLine(prompt);
}
