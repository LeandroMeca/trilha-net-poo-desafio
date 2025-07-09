namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
         public Iphone(String numero, String modelo, String imei, int memoria) : base(numero,modelo,imei,memoria){
             Console.WriteLine("Aparelho Iphone:");
         }


        // TODO: Sobrescrever o método "InstalarAplicativo"
         public override void InstalarAplicativo(string nomeApp){
            Console.WriteLine($"instalando o aplicativo {nomeApp} no dispositivo Iphone");
         }
    }
}