double n,sum=0;
n = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    sum+=Math.Pow(2,i);
}
Console.WriteLine(sum);