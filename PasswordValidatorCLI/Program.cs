Console.WriteLine("Hello, this tool allows for validing passwords.");
const string prompt = "Please enter a password to have it checked or type 'exit' to exit the application.";
Console.WriteLine(prompt);

using var stream = Console.OpenStandardInput();
using var reader = new StreamReader(stream);

string line;
while ((line = await reader.ReadLineAsync()) != "exit")
{           
    Console.WriteLine($"You wrote: {line}");
    Console.WriteLine(prompt);
}


Console.WriteLine("Exiting...");


