int size = int.Parse(Console.ReadLine());
string[,] matrix = new string[size,size];

int mineCount = 0;
int battleCruiseCount = 0;

int navyRowPosition = -1;
int navyColPosition = -1;

bool isLost = false;

for (int rows = 0; rows < size; rows++)
{
    string rowData = Console.ReadLine();
    for (int cols = 0; cols < size; cols++)
	{
        matrix[rows, cols] = rowData[cols].ToString();
        if (rowData[cols] == 'S')
		{
            matrix[rows, cols] = "-";
            navyRowPosition = rows;
			navyColPosition = cols;
		}		
	}
	
}
while(true)
{
    if (mineCount == 3)
    {
        Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{navyRowPosition}, {navyColPosition}]!");
        break;
    }
    if (battleCruiseCount == 3)
    {
        Console.WriteLine($"Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");
        break;
    }
    string readCommands = Console.ReadLine();
	switch (readCommands)
	{
		case "up":			
			navyRowPosition--;
			break;
        case "down":            
            navyRowPosition++;
            break;
        case "right":           
            navyColPosition++;
            break;
        case "left":            
            navyColPosition--;
            break;

    }
    if (matrix[navyRowPosition, navyColPosition] == "*")
    {
        matrix[navyRowPosition, navyColPosition] = "-";
        mineCount++;
    }
     if (matrix[navyRowPosition, navyColPosition] == "C")
    {
		matrix[navyRowPosition, navyColPosition] = "-";
        battleCruiseCount++;
    }


}
matrix[navyRowPosition,navyColPosition] = "S";

    for (int rows = 0; rows < matrix.GetLength(0); rows++)
	{
		for (int cols = 0; cols < matrix.GetLength(1); cols++)
		{
			Console.Write(matrix[rows,cols]);
		}
		Console.WriteLine();
	}


