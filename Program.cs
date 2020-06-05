namespace Aula11_atividade
{
    public class Program
    {
        static void Main(string [] args)
        {

            Calculo infoPlayer = new Calculo();

            System.Console.WriteLine( infoPlayer.Calcular() );

            System.Console.WriteLine( infoPlayer.Calcular(120) );

            System.Console.WriteLine( infoPlayer.Calcular(120,200) );

            System.Console.WriteLine( infoPlayer.Calcular("Excalibur", "Lendária") );

        }

    }
}