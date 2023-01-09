Console.WriteLine("Введите пятизначное число:");
int Num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int Temp = Num;
int Rev = 0;
while (Temp > 0)
{
    Rev *= 10;
    Rev += Temp % 10;
    Temp /= 10;
}
if (Rev == Num)
{
    Console.WriteLine("О чудо это палиндром!");
}
else
{
    Console.WriteLine("Это обычное число, чуда не будет.");
}
