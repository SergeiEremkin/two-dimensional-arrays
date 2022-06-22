int [,] FillArray(int rows,int col)
{
    int [,] arr = new int [rows,col];
    for(int i = 0; i< arr.GetLength(0); i++)
    {
        for(int j = 0; j< arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(1,10);
        }
       
    }   
    return arr;
}
void PrintArray(int[ , ] array)
{
    for(int i = 0; i< array.GetLength(0); i++)
    {
        for(int j = 0; j< array.GetLength(1); j++)
        {
            
            Console.Write($"{array[i,j]} ");
        }
        System.Console.WriteLine();
    }   
}
int[,] arr = FillArray(5,5);
PrintArray(arr);