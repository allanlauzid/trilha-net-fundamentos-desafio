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
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            string placa;
            do
            {
            Console.WriteLine("\nDigite a placa do veículo para estacionar:");
            placa = Console.ReadLine();
            placa = placa.ToUpper();
            } while (string.IsNullOrWhiteSpace(placa)); //*ALLAN*: IsNullOrWhiteSpace() identifica se a variável 'placa' está em branco ou nula
            while (veiculos.Contains(placa)) //*ALLAN*: verifica se a placa já foi inserida
            {
                Console.WriteLine($"O veículo de placa '{placa}' já está estacionado.");
                Console.WriteLine("\nDigite a placa do veículo para estacionar:");
                placa = Console.ReadLine();
                placa = placa.ToUpper();
            }
            veiculos.Add(placa);
            Console.WriteLine($"Veículo de placa '{placa}' adicionado com sucesso");
        }

        public void RemoverVeiculo()
        {
            //*ALLAN*: Não precisa inserir o do-while com IsNullOrWhiteSpace() pois se não é inserido um veículo com nome em branco, não vai ser necessário removê-lo.
            Console.WriteLine("\nDigite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            string placa = Console.ReadLine();
            placa = placa.ToUpper();
            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("\nDigite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*
                string entrada = Console.ReadLine();
                int horas;
                bool valido = int.TryParse(entrada, out horas);
                
                while(!valido)
                {
                    Console.WriteLine("Entrada inválida\nDigite um número inteiro");
                    entrada = Console.ReadLine();
                    valido = int.TryParse(entrada, out horas);
                    Console.WriteLine("\nDigite a quantidade de horas que o veículo permaneceu estacionado:");
                }

                decimal valorTotal = precoInicial + (precoPorHora * horas);

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*
                veiculos.Remove(placa);
                Console.WriteLine($"\nO veículo {placa} foi removido com sucesso\nValor total do Estacionamento: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("\nDesculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("\nExistem " +veiculos.Count +" veículos estacionados." +"\nAs placas dos veículos estacionados são:"); //*ALLAN*: veiculos.Count mostram a quantidade de itens na lista 'veiculos'
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
                int contador = 1; //*ALLAN*: contador para listar quantidade de veículos
                foreach (var veiculo in veiculos)//*ALLAN*: foreach permite listar os veículos que estão na lista 'veiculos'  de maneira mais prática, sem usar o for
                {
                    Console.WriteLine(contador + ". " + veiculo);
                    contador++;
                }
            }
            else
            {
                Console.WriteLine("\nNão há veículos estacionados.");
            }
        }
    }
}
