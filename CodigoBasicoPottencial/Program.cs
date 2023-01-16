//Subtraindo o produto e a soma de um número inteiro -DEV Davez

// int n = int.Parse(Console.ReadLine());
int n = int.Parse("234");
int p = 1, s = 0;
while (n > 0){
int l = n % 10;
// TODO: Crie as outras condições necessárias para a resolução do desafio:
p *= l;
s +=  l;
n /=  10;
} 
Console.WriteLine($"teste de valores, valor de p {p} e valor de s {s}");
Console.WriteLine(p-s);