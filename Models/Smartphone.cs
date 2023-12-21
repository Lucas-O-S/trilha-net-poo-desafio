namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        private string Modelo  { get; set; }
        private string Imei { get; set; }

        private int Memoria { get; set; }

        //Construtor que ajusta os dados pedidos
        protected Smartphone(string Numero, string Modelo, string Imei, int Memoria)
        {
            this.Numero = Numero;
            this.Modelo = Modelo;
            this.Imei = Imei;
            this.Memoria = Memoria;
        } 


        //Simula o celular ligando
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        //Simula uma ligação
        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        //Classe abstrata que instala um aplicativo que possui uma versão para cada aplicativo
        public abstract void InstalarAplicativo(string nomeApp);
    }
}