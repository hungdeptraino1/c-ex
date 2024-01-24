// See https://aka.ms/new-console-template for more information
Console.WriteLine("ngay sinh nguoi thu nhat: ");
int D1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("thang sinh nguoi thu nhat: ");
int M1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("nam sinh nguoi thu nhat: ");
int Y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ngay sinh nguoi thu hai: ");
int D2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("thang sinh nguoi thu hai: ");
int M2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("nam sinh nguoi thu hai: ");
int Y2 = Convert.ToInt32(Console.ReadLine());

int diffm = M1 - M2 + (Y1 - Y2) * 12;
int diffd = D1 - D2;

if (diffm < 0)
{
    Console.WriteLine("Nguoi 1 lon tuoi hon nguoi 2");
}
else
{
    if (diffm > 0)
    {
        Console.WriteLine("Nguoi 1 nho tuoi hon nguoi 2");
    }
    else 
    {
        if (diffd > 0)
        {
            Console.WriteLine("nguoi 1 nho tuoi hon nguoi 2");
        }else
        {
            if (diffd < 0)
            {
                Console.WriteLine("Nguoi 1 lon tuoi hon nguoi 2"); 
            }else
            {
                Console.WriteLine("Nguoi 1 bang tuoi nguoi 2");
            }
        }

    }
}


