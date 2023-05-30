public class Aluno
{
    public  string nome;
    public string email;
    public double media;
    
    public void CalcularMedia( double nota1, double nota2)
    {
        double media = (nota1 + nota2)/2;
        Console.WriteLine($"A média é {media}");

        if(media >= 6)
        {
            Console.WriteLine("Aprovado");
        }
        else if(media <= 5)
        {
            Console.WriteLine("Reprovado");
        }
    }//comenta
}