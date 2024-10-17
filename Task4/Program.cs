Console.WriteLine("Enter working hours in format: * * * * * * *");
var hours = Console.ReadLine().Split(" ");
int regularHourMoney = 0, overtimeHourMoney = 0, weekendHourMoney = 0;
for (int i = 1; i < 8; i++)
{
    int hour = Convert.ToInt32(hours[i - 1]);
    if (i < 6 && hour < 9 )
    {
        regularHourMoney += hour * 10;
    } else if (i >= 6)
    {
        weekendHourMoney += hour * 20;
    }
    else
    {
        regularHourMoney += 8 * 10;
        overtimeHourMoney = (hour - 8) * 15;
    }
}

Console.WriteLine(regularHourMoney + weekendHourMoney + overtimeHourMoney);
