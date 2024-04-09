namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine(string.Format("Instalando aplicativo {0} para Nokia.", nomeApp));
        }
    }
}