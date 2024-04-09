namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine(string.Format("Instalando aplicativo {0} para Iphone.", nomeApp));
        }
    }
}