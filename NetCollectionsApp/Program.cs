using System.Collections;
using System.Runtime.Intrinsics.X86;

ArrayList arrayList = new();

arrayList.Add(10);
arrayList.Add("Hello");
arrayList.Add(true);
arrayList.Add(56.45);
arrayList.Add(new { Name = "Bob", Age = 34 });

foreach (var item in arrayList)
    Console.WriteLine(item.ToString());

List<int> list = new List<int>();

Random random = new Random();
for(int i = 0; i < 10; i++)
    list.Add(random.Next(1, 99));

for(int i = 0;i < list.Count;i++)
    Console.Write($"{list[i]} ");
Console.WriteLine();

foreach(var item in list)
    Console.Write($"{item} ");
Console.WriteLine();

list.Sort();

foreach (var item in list)
    Console.Write($"{item} ");
Console.WriteLine();

list.Reverse();
foreach (var item in list)
    Console.Write($"{item} ");
Console.WriteLine();

LinkedList<int> l = new LinkedList<int>();

Dictionary<int, string> pairs = new();
pairs.Add(1, "One");

HashSet<int> set1 = new HashSet<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
foreach(var item in set1)
    Console.Write(item.ToString() + " ");
Console.WriteLine();

HashSet<int> set2 = new HashSet<int>() { 6, 7, 8, 9, 10, 11, 12 };
foreach (var item in set2)
    Console.Write(item.ToString() + " ");
Console.WriteLine();

var except = set1.Except(set2);
foreach (var item in except)
    Console.Write(item.ToString() + " ");
Console.WriteLine();

var inter = set1.Intersect(set2);
foreach (var item in inter)
    Console.Write(item.ToString() + " ");
Console.WriteLine();

var union = set1.Union(set2);
foreach (var item in union)
    Console.Write(item.ToString() + " ");
Console.WriteLine();


set1.SymmetricExceptWith(set2);
foreach (var item in set1)
    Console.Write(item.ToString() + " ");
Console.WriteLine();

Hashtable openWith = new Hashtable();

openWith.Add("txt", "notepad.exe");
openWith.Add("bmp", "paint.exe");
openWith.Add("dib", "paint.exe");
openWith.Add("rtf", "wordpad.exe");

foreach(var key in openWith.Keys)
    Console.WriteLine($"{key}: {openWith[key]}");

string s1 = "_abc**";
Console.WriteLine(s1.StartsWith("#"));
Console.WriteLine(s1.EndsWith("***"));

string s2 = "1997,Ford,E350,\"ac, abs, moon\",3000.00";
var arrs2 = s2.Split(",");
foreach (var item in arrs2)
    Console.WriteLine(item);

string[] dirs = { "D:", "Program Files", "Rpo", "CSharp" };
var path = String.Join("", dirs);
Console.WriteLine(path);

string s3 = "+++++++kjkjh kjh jgh++++++";
s3 = s3.Trim('+');
Console.WriteLine(s3);


string s4 = "Hello world, Hello people";
s4 = s4.Replace("Hello", "");
Console.WriteLine(s4);

DateTime dateNow = DateTime.Now;
DateTime date = new DateTime(2010, 5, 22);

Console.WriteLine(dateNow.AddMonths(10).ToString("F"));

Console.WriteLine(dateNow.Subtract(date));

int n;
if(!Int32.TryParse("123",out n))
    Console.WriteLine("Error");
else
    Console.WriteLine(n);