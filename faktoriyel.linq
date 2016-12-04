<Query Kind="Program" />

void Main()
{
	// c# for döngü
	int i, sayi, faktoriyel=1; 
	sayi=Convert.ToInt32(Console.ReadLine());
	for(i=1;i<=sayi;i++)
	{
	faktoriyel=faktoriyel*i;
	}
	Console.Write("sonuç:" + faktoriyel);
}


// Define other methods and classes here
