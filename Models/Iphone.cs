namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no IPhone");
        }
        public override void NovoNumero(string numero)
        {
            Numero = numero;
            Console.WriteLine($"O novo número de seu IPhone é {numero}");
        }
    }
}