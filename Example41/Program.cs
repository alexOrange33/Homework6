// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4

System.Console.WriteLine("Введите массив чисел через пробел: ");
string stringArray = Console.ReadLine()!;
string[] nums = GetStringMass(stringArray);


System.Console.WriteLine(String.Join(",", nums) +" -> "+ UpZero(nums));


//---------metods-----------
string[] GetStringMass(string stringArray)
{
    string[] nums = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    return nums;
}

int UpZero(string[] nums)
{
    int[] temp = new int[nums.Length];
    int count = 0;
    for(int i = 0; i < nums.Length;i++)
    {
        temp[i] = int.Parse(nums[i]);
        if(temp[i] > 0) count++;
    }
    return count;
}