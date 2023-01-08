namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // Solicita ao usuário digitar uma placa e adiciona na lista "veiculos".
            
             

            Console.WriteLine("Digite a placa do veículo para estacionar:");
            veiculos.Add(Console.ReadLine());
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");


            // Pedi para o usuário digitar a placa do veículo.
            
            string placa = "";
            placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // Solicita para usuário digitar a quantidade de horas que o veículo permaneceu estacionado.
                
                int horas = 0;
                horas = Convert.ToInt32(Console.ReadLine());

                decimal valorTotal = 0; 
                valorTotal = (precoInicial + precoPorHora) * horas;

                // Remove a placa digitada da lista de veículos.
                
              veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento.
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                //Exibi os veículos estacionados.
               

                foreach(string veiculo in veiculos) {
                     Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
