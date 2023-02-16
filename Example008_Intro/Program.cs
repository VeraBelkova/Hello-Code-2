int Max(int arg1, int arg2, int arg3)
{
 int result = arg1;
 if (arg2> result) result = arg2; 
 if (arg3> result) result = arg3; 
 return result;
}
int a1 = 1;
int b1 = 2;
int c1 = 3;
int a2 = 4;
int b2 = 5;
int c2= 6;
int a3 = 7;
int b3 = 8;
int c3 = 9;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(max1, max2, max3);
Console.WriteLine(max);