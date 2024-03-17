

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




/*Taxt 3 +   */

/*int num = 4;
int fac = 1;

for (int i = num; i > 0; i--) 
{
    fac = fac * i;
}
Console.WriteLine(fac);*/



/*Taxt 4 + */
/*int num = 12;

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





/*Taxt 7 +  */

/*int num = 454;
int teklik = 0;
int onluq = 0;
int yuzluk = 0;
int a = 0;

a = num / 10;
teklik = num % 10;
onluq = a % 10;
yuzluk = num / 100;

if (teklik == onluq && onluq == yuzluk)
{
    Console.WriteLine("butun reqemler beraberdi");
}
else
{
    Console.WriteLine("butun reqemler beraber deyil");
}*/






/*Taxt 8 */



/*int num = 8;
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
}*/




/*Taxt 9 +  */

/*int num = 233;
int sum = 0;
int a = 0;

while (num > 0)
{
    a= num % 10;
    sum = sum + a;
    num /= 10;
}

Console.WriteLine(sum);*/





/*Taxt 10 + */

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


/*int[] arr = { 2, 3, 11, 4, 5, 61, };
int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (0<arr[i] && arr[i]<10)
    {
        count++;
    }
}
Console.WriteLine(count);*/



/*Taxt 12 +  */


/*int num = 33;
int a = 0;
int b = 0;

a = num / 10;
b = num % 10;

if (a > b)
{
    Console.WriteLine("onluq boyukdu");
}
else if (a == b)
{
    Console.WriteLine("beraberdi");
}
else
{
    Console.WriteLine("teklik boyukdur");
}*/





/*Taxt 13 + */

/*int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
int max = 0;
int min = 0;


for (int i = 0; i < arr.Length; i++)
{
    if (arr[max] < arr[i])
    {
        max=i;
    }
    if (arr[min] > arr[i])
    {
        min=i;
    }
}
arr[max] += arr[min];
arr[min] = arr[max] - arr[min];
arr[max] = arr[max] - arr[min];
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}*/





/*Taxt 14 +



int num = 918;
int count = 0;


while (num > 0)
{
    num = num / 10;
    count++;
}
Console.WriteLine(count);*/



/*Taxt 15 +  *//*


int num = 333;

Console.WriteLine("7"+num+"8");
*/






/*Taxt 16 + */


/*int num = 23;

Console.WriteLine(num +""+ num);*/





/*Taxt 17 + */



/*int num = 333;
string a = num + "7";
int sum = Convert.ToInt32(a);

sum = sum * 7 / 100;

Console.WriteLine(sum);*/







/*Taxt 18 + 

/*int num = 2;


if (num % 2 == 0 && num > 0)
{
    Console.WriteLine("cut ededir");
}
else if (num > 0 && num % 2 != 0)
{
    Console.WriteLine("tek ededir");
}
else 
{
    Console.WriteLine("tek ve cut eded deyil");
}*/



/*Taxt 19 +  */


/*int num = 21;

if(num%21==0)
{
    Console.WriteLine("eded 7e ve 3e tam bolunur ");
}
else
{
    Console.WriteLine("eded 7e ve 3e tam bolunmur");
}*/


/*Taxt 20 +  */

/*int num = 23;
int max = 0;
int a = 0;
while(num>0)
{
    a = num % 10;
    if (max < a)
    {
        max = a;
    }
    num=num/ 10;
}
Console.WriteLine(max);*/



/*Taxt 21 +  */

/*string[] arr = { "ab104", "ab101", "ab106", "cd106" };
bool result = false;


for(int i = 0; i < arr.Length; i++)
{
    if (arr[i] =="ab106")
    {
        result = true;
        break;
    }
}
if(result)
{
    Console.WriteLine("var");
}
else
{
    Console.WriteLine("yoxdu");
}*/





/*Taxt 22 +   */

/*int M = 35;
int count = 0;
for (int i = 1; i < M; i++)
{
    if(i%15==0)
    {
        count++;
    }
}
Console.WriteLine(count);*/





/*Taxt 2 + */


/*int[] arr1 = { 1, 2, 3, 4, 5, 6, 7 };
int[] arr2 = { 2, 6, 8, 9 };

for (int i = 0; i < arr1.Length; i++)
{
    for (int j = 0; j < arr2.Length; j++)
    {
        if (arr1[i] == arr2[j])
        {
            Console.WriteLine(arr1[i]);
        }
    }
}*/





/*Taxt 3 +  */

/*int[] arr = { 5, 2, 4, 1 };
int temp = 0;
for (int i = 0; i < arr.Length; i++)
{
    for (int j = i + 1; j < arr.Length; j++)
    {
        if (arr[j] < arr[i])
        {
            temp = arr[j];
            arr[j] = arr[i];
            arr[i] = temp;
        }
    }
    Console.WriteLine(arr[i]);
}*/

