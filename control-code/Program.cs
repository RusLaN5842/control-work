string[] arrayOne = new string[5] {"Rus", "US", "DEllo", "world", "rec"};
string[] arrayTwo = new string[arrayOne.Length];
void CreateArray(string[] arrayOne, string[] arrayTwo)
{
    int count = 0;
    for (int i = 0; i < arrayOne.Length; i++)
    {
    if(arrayOne[i].Length <= 3)
        {
        arrayTwo[count] = arrayOne[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++) 
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}
CreateArray(arrayOne, arrayTwo);
PrintArray(arrayTwo);
