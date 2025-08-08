string s = Console.ReadLine();

int tcCount = int.Parse(s);

for(int i = 0; i < tcCount; i++)
{
    string[] ss = Console.ReadLine().Split(' ');

    int left = int.Parse(ss[0]);
    int right = int.Parse(ss[1]);

    int total = 1;

    for(int j = 1; j <= left; j++)
    {
        total *= right--;
        total /= j;
    }

    Console.WriteLine(total);
}