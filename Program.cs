// The goals of the project are in the file 'project-goals.txt'

List<string> carPlatesId = new List<string>();
decimal initialPrice;
decimal pricePerHour;
int menuOption = 0;

// Initializing the program taking the prices
Console.WriteLine("Digite o valor inicial do estacionamento:");
initialPrice = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o valor por hora do estacionamento:");
pricePerHour = Convert.ToDecimal(Console.ReadLine());
Console.Clear();


do {

    Console.Write(
        "1 - Cadastrar veículo\n" +
        "2 - Remover veículo\n" +
        "3 - Listar veículos\n" +
        "4 - Encerrar\n" +
        "Digite sua opção:  "
    );
    menuOption = Convert.ToInt32(Console.ReadLine());
    Console.Clear();

    switch (menuOption) {

        // Register the vehicle
        case 1:
            Console.WriteLine("Digite a placa do veículo:");
            string carPlate = Console.ReadLine();
            carPlatesId.Add(carPlate);
            break;


        // Removing the vehicle
        case 2:
            Console.WriteLine("Qual dos veículos quer remover?:\n");
            int count = 0;
            foreach(string cars in carPlatesId) {
                Console.WriteLine($"{count} - {cars}");
                count++;
            }

            int carToRemove = Convert.ToInt32(Console.ReadLine());
            carPlatesId.RemoveAt(carToRemove);

            Console.WriteLine($"Quanto tempo o carro ficou? (em horas)");
            int parkedTime = Convert.ToInt32(Console.ReadLine());
            decimal totalPrice = (initialPrice + (pricePerHour * parkedTime));

            Console.WriteLine($"O valor a pagar é R${totalPrice} reais");
            break;

        // Printing the vehicles list
        case 3:
            Console.WriteLine("Lista de veículos no estacionamento:");
            int count2 = 0;
            foreach(string cars in carPlatesId) {
                Console.WriteLine($"{count2} - {cars}");
                count2++;
            }
            Console.WriteLine("------------------------------");
            break;

        //  Exiting the loop 
        case 4:
            Console.WriteLine("O programa será encerrado.");
            break;

        default:
            Console.WriteLine("Entrada inválida");

            break;
    }


} while (menuOption != 4);

Console.WriteLine("Obrigado e volte sempre!");
Console.WriteLine("------------------------");