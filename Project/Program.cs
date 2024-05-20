string[] array1 = new string[6] {"start", "25", "367", "cater", "big","466"};
string[] SecondArray(string[] array1)
{
    int count = 0;
    for (int i = 0; i < array1.Length; ++i)
    {
    if(array1[i].Length <= 3)
        {
        ++count;
        }
    }
    string[] res = new string[count];
    int j = 0;
    for (int i = 0; i < array1.Length; ++i)
    {
    if(array1[i].Length <= 3)
        {
        res[j++] = array1[i];
        }
    }
    return res;
}   
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; ++i)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
string[] array2 = SecondArray(array1);
PrintArray(array1);
PrintArray(array2);