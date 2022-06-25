int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int a1 = 12;
int b1 = 23;
int c1 = 12;
int a2 = 30;
int b2 = 33;
int c2 = 12;
int a3 = 358;
int b3 = 41;
int c3 = 139;

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine(max);
