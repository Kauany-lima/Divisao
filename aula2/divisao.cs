/*int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

int divisao = a / b;
Console.WriteLine(divisao);
*/
try
{
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());

    int divisao = a / b;
    Console.WriteLine("o resultado é " + divisao);

}
catch(Exception ex)
{
    Console.WriteLine("Algo de errado não está certo");
}