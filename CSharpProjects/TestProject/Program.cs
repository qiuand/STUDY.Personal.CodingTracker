string str = "The quick brown fox jumps over the lazy dog.";
// convert the message into a char array
char[] charMessage = str.ToCharArray();
// Reverse the chars
Array.Reverse(charMessage);
int x = 0;

foreach (char i in charMessage)
{
    if (i == 'o') { x++; }
}

string new_message = new String(charMessage);

Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");