// 3 / 3 - A Corrida de Tartarugas - DEV Davez


    int quantidadeEntradas = 3;
    int count = 0;
      
    while (quantidadeEntradas > 0) {

      //declaração teste;
      //var numeroQuantidade = Int32.Parse("10");

      //declaração desafio;
      var numeroQuantidade = Int32.Parse(Console.ReadLine());
        
      if (numeroQuantidade >= 1 && numeroQuantidade <= 500) {
        //declaração teste;
        //string[] tartarugas = "10 10 10 10 15 18 20 15 11 10".Split(" ");

        //declaração desafio;
        string[] tartarugas = Console.ReadLine().Split(" ");

        var maiorVelocidade = Int32.Parse(tartarugas[0]);
          
// TODO: Crie as outras condições necessárias para a resolução do desafio:
        for (int i = 0; i < tartarugas.Length; i++) {
          var tartaruga = Int32.Parse(tartarugas[i]);

          if (tartaruga >= count) {
            maiorVelocidade = tartaruga;
          }
          count = tartaruga;
        }

        if(maiorVelocidade < 10) {
          Console.WriteLine(1);
        } else if (maiorVelocidade >= 10 && maiorVelocidade < 20) {
          Console.WriteLine(2);
        } else if (maiorVelocidade >= 20) {
          Console.WriteLine(3);
        }
        quantidadeEntradas--;
      } else {
        Console.WriteLine("Insira um número entre 1 e 500");
      }
    }