int size = int.Parse(Console.ReadLine());
string carName = Console.ReadLine();

string[,] matrix = new string[size,size];


bool isFirstFound = false;
bool isFinished = false;
int firstTunnelRow = 0;
int firstTunnelCol = 0;

int secondTunnelRow = 0;
int secondTunnelCol = 0;

for (int row = 0; row < size; row++)
{
    string[] rowData = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
	
	for (int col = 0; col < size; col++)
	{
		if (rowData[col] == "T" && !isFirstFound)
		{
			firstTunnelRow = row;
			firstTunnelCol= col;
			isFirstFound = true;
		}
		else if (rowData[col] == "T")
		{
			secondTunnelRow = row;
			secondTunnelCol= col;	
		}

		matrix[row, col] = rowData[col];
	}
}

string command;

int carRow = 0;
int carCol = 0;
int kms = 0;

while ((command = Console.ReadLine())!= "End")
{
	if(command == "down")
	{
		carRow++;
	}
    if (command == "up")
	{
		carRow--;
	}
    if (command == "right")
	{
		carCol++;
	}
    if (command == "left")
    {
        carCol--;
    }


    if (matrix[carRow,carCol] == ".")
	{
		kms += 10;
	}
	if (matrix[carRow,carCol] == "T")
	{
		matrix[carRow, carCol] = ".";
		if(carCol == firstTunnelCol && carRow == firstTunnelRow)
		{
			carRow = secondTunnelRow;
			carCol = secondTunnelCol;
		}
		else
		{
			carRow = firstTunnelRow;
			carCol = firstTunnelCol;
		}

        matrix[carRow, carCol] = ".";
        kms += 30;

	}
	if (matrix[carRow,carCol] == "F")
	{
		kms += 10;
		isFinished = true;
		break;
	}
}
matrix[carRow, carCol] = "C";

if (isFinished)
{
    Console.WriteLine($" Racing car {carName} finished the stage!");
}
else
{
	Console.WriteLine($"Racing car {carName} DNF.");
}

Console.WriteLine($"Distance covered {kms} km.");
PrintMatrix(matrix);

static void PrintMatrix<T>(T[,] matrix)
{
	for (int row = 0; row < matrix.GetLength(0); row++)
	{
		for (int col = 0; col < matrix.GetLength(1); col++)
		{
			Console.WriteLine(matrix[row,col]);
		}
		Console.WriteLine();
	}
}