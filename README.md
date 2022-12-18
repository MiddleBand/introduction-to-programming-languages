## introduction-to-programming-languages 


# 1 Написать "Привет Мир"


Console.WriteLine ("Hello World");



# 2 Поприветствовать пользователя

Console.Write("Введите ваше имя ");
string username = Console.ReadLine();
Console.Write("Привет, ");
Console.Write(username);



# 3 Сумма рандомных чисел

int namberA = new Random ().Next (1, 10);
Console.WriteLine (namberA);
int namberB = new Random ().Next (1, 10);
Console.WriteLine (namberB);
int result = namberA + namberB;
Console.WriteLine (result);



# 4 Деление чисел

double namberA = new Random ().Next (1, 10);
Console.WriteLine (namberA);
double namberB = new Random ().Next (1, 10);
Console.WriteLine (namberB);
double result = namberA / namberB;
Console.WriteLine (result);


# 5 Поособенному поприветствовать Машу

Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
  Console.WriteLine("Ура, это же Маша!");  
}
else
{
  Console.Write("Привет, ");
  Console.WriteLine(username);
}




# 6 Найти наибольшее значение

int a = 1;
int b = 2;
int c = 6;
int d = 8;
int e = 4;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("max = ");
Console.WriteLine(max);



# 7 нарисовать треугольник

Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");

int xa = 40,  ya = 1, 
    xb = 1,  yb = 30,
    xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = xb;

int count = 0;

while (count < 100000)
{
    int what = new Random().Next(0, 3); // [0;3) 0 1 2
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb)  /2;
    }

    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}
