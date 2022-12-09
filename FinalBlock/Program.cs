// See https://aka.ms/new-console-template for more information

string[] words = { "hi", "hello", "goodbye", "ok" };
int count = 0;
foreach (string i in words)
{
    if (i.Length < 4)
    {
        count++;
    }
}

string[] newWords = new string[count];
count = 0;
foreach (string i in words)
{
    if (i.Length < 4)
    {
        newWords[count] = i;
        count++;
    }
}

Console.WriteLine(String.Join(", ", words));
Console.WriteLine(String.Join(", ", newWords));