

/*Taxt 1 + */

/*int hava=14;
if(hava<15)
{
    Console.WriteLine("hava soyuqdur");
}
else
{
    Console.WriteLine("hava isdidir");
}*/



/*  Taxt 2 + */

/*string month = "may";

switch (month)
{
    
    case "fevral":
        Console.WriteLine("29");
        break;
   
    case "Yanvar":
    case "mart":
    case "may":
    case "iyul":
    case "avqust":
    case "sentyabr":
    case "noyab":
        Console.WriteLine("31");

        break;
    case "apre":
    case "iyun":
    case "oktyabr":
    case "dekabr":
        Console.WriteLine("30");
        break;
}*/



/*Taxt 3 */

/*int num=5;
int max = 0;
if(num>0)
{
    for (int i = 1; i <=num; i++) 
    {
        if (num % i == 0)
        {
            max++;
        }
    }
}
Console.WriteLine(max);*/


/*Taxt 4 + */
/*int num=12;

for (int i = 2; i <= num; i++)
{
    if (num % i == 0)
    {
        Console.WriteLine("murekeb");
        break;
    }
    else
    {
        Console.WriteLine("sade");
        break;
    }
}*/



/*Taxt 5 + */

/*int[] arr = { 1, 2, 3, };
int sum = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 != 0)
    {
        sum += arr[i];
    }
}
Console.WriteLine(sum);*/


/*Taxt 6 + */

/*int[] arr = { 1, 2, 3, 4 };
int max = arr[0];

for (int i = 0; i < arr.Length; i++)
{
    if (max < arr[i])
    {
        max = arr[i];
    }
}
Console.WriteLine(max);
*/



/*int num = 221;
int first = 0;
bool result = false;

while (first != 0)
{
    int temp = first % 10;
    int second = first / 10;
   while (second != 0)
   {
       if (temp == second % 10)
       {
           result = true;
            break;
        }
        second /= 10;
    } 
    first /= 10; 
}
if (false == result) 
{
    Console.WriteLine("bütün rəqəmlər bərabər deyil");
}*/



/*Taxt 8 */

int num = 8;
int i = 2;

while (num % i == 0)
{
    num = num % i;
}
if (num == 1)
{
    Console.WriteLine("2 nin qwvvet usdudur");
}
if (num % i != 0)
{
    num % i =
}



/*int num = 23;
int a = 0;
int b = 0;
int sum = 0;


a = num % 10;
b = num / 10;
sum = a + b;
Console.WriteLine(sum);*/




/*Taxt 10 +*/

/*int[] arr = {  2, 3, 4, 5, 6,1};
int min = arr[0];
for (int i = 0; i < arr.Length; i++)
{
    if (min > arr[i]) 
    {
        min= arr[i];
    }
}
Console.WriteLine(min);*/




/*Taxt 11 +  */


/*int[] arr = { 2, 3, 11, 4, 5, 61 };
int count = 0;

for(int i=0;i<arr.Length;i++)
{
    if (arr[i]>9)
    {
        count++;
    }
}
Console.WriteLine(count);*/



/*Taxt 12 +  */


/*int num = 23;
int a = 0;
int b = 0;

a = num / 10;
b = num % 10;

if (a > b)
{
    Console.WriteLine("onluq boyukdu");
}
else
{
    Console.WriteLine("teklik boyukdur");
}*/







