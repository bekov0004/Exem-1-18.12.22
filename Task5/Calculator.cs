public class Calculator
{
public long Factorial(long n)
{
 int factorial=1;
for (int i = 1; i <= n; i++)
{
    factorial = factorial*i;
} 
    return factorial;
}
public double Multiple(double a, double b)
{
   return a*b;
}
public double Division(int a, int b)
{
    return a/b;
}
}