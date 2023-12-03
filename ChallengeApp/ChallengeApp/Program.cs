var number = 12345655440;
string numberAsstring = number.ToString();
char[] letters = numberAsstring.ToArray();
char[] Check = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
int[] counters = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
for (int i = 0; i < letters.Length; i++)
{
    for (int j = 0; j < Check.Length; j++)
    {
        if (letters[i] == Check[j])
        {
            counters[j]++;
        }
    }
}
Console.Write("Wyniki dla liczby "); Console.WriteLine(number);
for (int i = 0; i < 10; i++)
{
    Console.Write("liczba "); Console.Write(i); Console.Write(" jest "); Console.WriteLine(counters[i]);
}

