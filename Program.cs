//get input from user
Console.Write("Enter x: ");
int input = Convert.ToInt32(Console.ReadLine());

void write(int i)
{
    for (int x = 1; x <= i; x++)
    {
        Console.Write("{0} ", x * i);
    }
    Console.WriteLine("");
}

int counter = 1;
int interval = 1;

while (counter > 0)
{
    write(counter);

    //loop through number range
    counter = counter + interval;
    if (counter > input)
    {
        counter = input - 1;
        interval = interval * -1;
    }
}
