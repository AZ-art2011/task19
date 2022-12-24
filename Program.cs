// task 19

string checking(int num){
    
    int num1 = num % 10;
    int num2 = num / 10 % 10;
    int num3 = num / 10000 % 10;
    int num4 = num / 1000 % 10;

    if (num1 == num3 & num2 == num4)
    {
        return $"Число {num} является палиндромом";
    }
    
    else
    {
        return $"Число {num} не является палиндромом";
    }

}

int x1 = 14212;
Console.WriteLine(checking(x1));
int x2 = 12821;
Console.WriteLine(checking(x2));
int x3 = 23432;
Console.WriteLine(checking(x3));

