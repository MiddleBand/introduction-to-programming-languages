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

# 8 Найти наибольшее из 9 чисел

int Max(int arg1,int arg2,int arg3)
{
    int result = arg1;
    if (arg2 > result) result =arg2;
    if (arg3 > result) result =arg3;
    return result;
}
int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 33;
int b2 = 1244;
int c2 = 23;
int a3 = 135;
int b3 = 21;
int c3 = 39;

// int max = a1;
// if(b1>max) max=b1;
// if(c1>max) max=c1;

// if(a2>max) max=a2;
// if(b2>max) max=b2;
// if(c2>max) max=c2;

// if(a3>max) max=a3;
// if(b3>max) max=b3;
// if(c3>max) max=c3;

// или так

// int max1 = Max(a1,b1,c1);
// int max2 = Max(a2,b2,c2);
// int max3 = Max(a3,b3,c3);
// int max = Max(max1,max2,max3);

// или так

int max = Max(Max(a1,b1,c1),Max(a2,b2,c2),Max(a3,b3,c3));

Console.WriteLine(max);

# 8 Массив

int Max(int arg1,int arg2,int arg3)
{
    int result = arg1;
    if (arg2 > result) result =arg2;
    if (arg3 > result) result =arg3;
    return result;
}
int[] array = {11,27,38,4,45,611,76,8,19};
// array[0] = 12;
// Console.WriteLine(array[4]);

int result = Max (
 Max (array[0],array[1],array[2]),
 Max (array[3],array[4],array[5]),
 Max (array[6],array[7],array[8])
);
Console.WriteLine(result);

# 9 Поиск позиции нужного элемента

int[] array = {1,26,53,54,15,66,75,84,98};

int n = array.Length;
int find = 26;

int index = 0;

while (index < n)
{
    if (array[index] == find)

    {
     Console.WriteLine(index);
     break;
    }
 index = index + 1;
}
 Console.WriteLine(index);
 
 # 10 Берем метод, Передаем в него массив, Заполняем нужны колличеством элементов
 
 void FillArray(int[] collection) 

{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;    
    }
}

int indexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while(index < count)
    {
        if(collection[index] == find)
        {
          position = index;
          break;
        }
        index++;
    }
    return position;
}

int[] array = new int [10];


FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = indexOf(array, 4);
Console.WriteLine(pos);
