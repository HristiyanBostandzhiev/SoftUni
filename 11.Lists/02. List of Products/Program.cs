List<string> products = new List<string>();
int n = int.Parse(Console.ReadLine());

for  (int i = 1; i <= n; i++)
{
    products.Add(Console.ReadLine());
}

products.Sort();

int num = 1;
foreach (string product in products)
{
    Console.WriteLine(num + "." + product);
    num++;
}