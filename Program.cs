// See https://aka.ms/new-console-template for more information
using System.Text.Json;
Console.WriteLine("Hello, World!");
int a = 121;
string s = "MCMX";
string x = "hello world";

test(a);

int[] c = new int[] { 3, 2, 2, 3 }; int Val = 3;
Console.WriteLine(RemoveElement(c, Val));

Console.WriteLine(tinhtong(s));

Console.WriteLine(LengthOfLastWord(x));

///////////////////////////////////////////
//int[] a = new int[] { 8,9,9,9 };
//Console.WriteLine(using System.Text.Json;(PLusTwo(a)));
/////////////////////////////////////////////////////////////
//string[] b = new string[] { "flower", "flow", "flight" };
//Console.WriteLine(JsonSerializer.Serialize(LongestCommonPrefix(b)));
//////////////////////////////////////////////////////////////////////////


static void test(int a)
{
	int b = a;
	int tong = 0;
	while (a > 0)
	{
		int luutru = a % 10;
		a = a / 10;
		tong = (tong * 10) + luutru;


	}
	if (tong == b)
	{
		Console.WriteLine(true);

	}
	else
	{ 
		Console.WriteLine(false);
	
	}

}
static int tinhtong(string s)
{
	
	var tong = 0;
	for (int i = 0; i < s.Length; i++)
	{
		if (i > 0 && so(s[i]) > so(s[i - 1]))
		{
			tong += so(s[i]) - so(s[i - 1]) * 2;
		}
		else
		{ 
			tong+= so(s[i]);
		
		}
	
	}


	return tong;
}
static int so ( char truonghop )
{
	switch (truonghop)
	{
		case 'I':
			return 1;
		case 'V':
			return 5;
		case 'X':
			return 10;
		case 'L':
			return 50;
		case 'C':
			return 100;
		case 'D':
			return 500;
		case 'M':
			return 1000;

	}return 0;
}
static int LengthOfLastWord(string x)
{
	
	int dem = 0, dodai = 0;


	foreach (var a in x.Split(' '))


		Console.WriteLine(a);


	for (int i = 0; i <x.Length; i++)
	{
		if (x[i] != ' ')
		{
			dem++;
			dodai = dem;
		}
		else
		{
			dodai = 0;
			if (dodai < dem)
			{
				dodai = dem;
			}
		}
	}

	return dodai;


}

Console.WriteLine("--------------------------------------------------");

static int LengthOfLastWord1(string x)
{
	string[] xArray = x.Trim().Split(" ");
	string lastWord = xArray[xArray.Length - 1];
	Console.WriteLine(lastWord);

	return lastWord.Length;
}

string xxx = "   fly me   to   the moon  ";
var result = LengthOfLastWord1(xxx);
Console.WriteLine(result);

static int[] PlusOne(int[] a)
{
	
	int socuoi =  a[a.Length - 1];
	socuoi = socuoi + 1;
	a[a.Length - 1] = socuoi;
	if (socuoi + 1 == 10)
	{

		a[a.Length - 1 - 1] = a[a.Length - 1 - 1] + 1;
	
	}
	
		return a;
	
}

static int[] PLusTwo(int[] b) 
{
	List<int> result = new List<int>();
	var flag = 0;


	for (int i = b.Length - 1; i >= 0; i--) 
	{
		var sum = 0;
		if (i == b.Length - 1)
		{
			sum = b[i] + 1;
		}
		else {
			sum = b[i];
		}
		
		b[i] = sum;

		if (sum >= 10)
		{
			b[i] = 0;
			if ((i - 1) < 0)
			{
				flag = 1;
			}
			else
			{
				b[i - 1] = b[i - 1] + 1;///// b[2]=b[3] +1
			}
		}
		else {
			break;
		}	
	}

	if (flag == 1)
	{
		result.Add(1);
		foreach (var item in b)
		{
			result.Add(item);
		}

		return result.ToArray();
	}

	return b;

}
/////////////////////////////////////
//static string LongestCommonPrefix(string[] b)
//{
//	int count = 0;

//	int dem = 0;


//	for (int i = 0; i < b.Length; i++)
//	{
//		for (int j = i + 1; j < b.Length; j++)
//		{
//			if (b[i] == b[j])
//			{

//				Console.WriteLine("b[i,j]");

//			}
//			else
//			{
//				Console.WriteLine(" ");

//			}


//		}




//	}
	///////////////////////////////////////
	//if (b.Length == 0)
	//{
	//	return "";

	//}
	//string prefix= b[0];
	//for (int i = 1; i < b.Length; i++)
	//{
	//	while (b[i].IndexOf(prefix) != 0)
	//	{
	//		Console.WriteLine(b[i].IndexOf(prefix));
	//		prefix=prefix.Substring(0, prefix.Length - 1);

	//	}

	//}

	//return prefix;
	//}
	//////////////////////////////////////////////////////////////////////////////////////////////////////

	//string[] arr = { "clone", "clound", "clo", "cat" };
	//for (int i = 0; i < b.Length; i++)
	//{
	//	if (b[i].Contains("fl"))
	//		dem++;
	//}
	//Console.WriteLine(dem);

	//for (int i = 0; i < b.Length; i++)
	//{
	//	for (int j = i + 1; j < b.Length; j++)
	//	{
	//		if (b[i] == b[j])
	//		{

	//			Console.WriteLine("b[i,j]");

	//		}
	//		else
	//		{
	//			Console.WriteLine(" ");

	//		}


	//	}




	//}

	//	return null;
	//}
	///////////////////////////////////////////////////////////
	static int RemoveElement(int[] c, int Val)
{
	//string[] result = Array.ConvertAll(c, x => x.ToString());
	//int k = 0;
	//for (int i = 0; i < c.Length; i++)
	//{
	//	if (c[i] == Val)
	//	{
	//		k++;
	//		result[i] = "_z"; 
	//	}
	//}
	//return (k,Array.ConvertAll(result, x=>(int)x));

	int j=0;
	int [] b=new int[c.Length];
	for (int i = 0; i < c.Length; i++)
	{
		if (c[j] != Val)
		{

			c[j] = c[i];
			j++;
		}
	}

		return j;

}



