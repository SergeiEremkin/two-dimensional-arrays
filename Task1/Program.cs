int[ , ] arr = new int[ , ]
{{1,1,1,1,1,1},
 {1,0,0,0,0,1},
 {1,0,0,0,0,1},
 {1,1,1,1,1,1}
};

void PrintArray(int[ , ] array)
{
    for(int i = 0; i< array.GetLength(0); i++)
    {
        for(int j = 0; j< array.GetLength(1); j++)
        {
            
            if(array[i,j] ==0)
            {
                System.Console.Write($" ");
            }
            else 
            {
                System.Console.Write($"+");
            }
        }
        System.Console.WriteLine();
    }   
}

void FillArray(int row, int col )
{
    if(arr[row, col] ==0)
    {
        arr[row, col]= 1;
        FillArray(row -1, col);
        FillArray(row , col-1);
        FillArray(row+1 , col);
        FillArray(row , col+1);
    }
}

PrintArray(arr);
FillArray(2,2);
System.Console.WriteLine();
PrintArray(arr);
