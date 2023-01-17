//Encaixa ou Não? - DEV Davez

//int qt = int.Parse(Console.ReadLine());
int qt = int.Parse("1");
// TODO: Crie as outras condições necessárias para a resolução do desafio:
        for (int i = 0; i < qt ; i++)
        {
            //string[] v = Console.ReadLine().Split("");
            string teste = "56234523485723854755454545478690 78690";
            string[] v = teste.Split();
            string a = v[0];
            string b = v[1];

            if (!a.EndsWith(b))
                Console.WriteLine("nao encaixa");
            else if (a.EndsWith(b))
                Console.WriteLine("encaixa");
            else
                Console.WriteLine("nao encaixa");

        }





/*
Esse código comentado a baixo é o que funcionará na aplicação do console web, ele precisava
ser referenciado como "using static System.Console;" e retirado os consoles das indicações de 
writeline e readline
*/

// using static System.Console;
// class teste{

//     static void Main(string[] args)
//     {
//         int qt = int.Parse(ReadLine());
//         // TODO: Crie as outras condições necessárias para a resolução do desafio:
//         for (int i = 0; i < qt ; i++)
//         {
//             string[] v = ReadLine().Split();
//             string a = v[0];
//             string b = v[1];

//             if (a.EndsWith(b)) {
//                 WriteLine("encaixa");
//             }
//             else{
//                 WriteLine("nao encaixa");
//             }
//         }

//     }