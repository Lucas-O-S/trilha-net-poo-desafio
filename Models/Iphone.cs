namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {

        //Cria um constutor proprio com base no original
        public Iphone(string Numero, string Modelo, string Imei, int Memoria) : base(Numero, Modelo, Imei, Memoria)
        {

        
        }


        // TODO: Sobrescrever o método "InstalarAplicativo"

        //Sobrescreve o metodo original com base no Iphone
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo '{nomeApp}' no seu celular Iphone");
        }

    }
}