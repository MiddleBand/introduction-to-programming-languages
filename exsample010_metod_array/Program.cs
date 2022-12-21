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