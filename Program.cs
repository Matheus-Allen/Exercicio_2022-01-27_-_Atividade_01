int peso;
float alt, imc;
Console.WriteLine("1. Desenvolva uma aplicação que calcule o IMC de acordo com as informações inseridas.");
Console.Write("Digite o seu peso:");
peso = int.Parse(Console.ReadLine());
Console.Write("Digite o seu altura:");
alt = float.Parse(Console.ReadLine());

imc = peso / (alt * alt);
Console.WriteLine("Seu imc é: " + imc);

if (imc < 18.5)
{
    Console.WriteLine("Abaixo do peso");
}
else if (imc > 18.5 && imc > 24.9)
{
    Console.WriteLine("Peso normal");
}
else if (imc > 25 && imc < 29.9)
{
    Console.WriteLine("Sobrepeso I");
}
else if (imc > 30 && imc < 39.9)
{
    Console.WriteLine("Sobrepeso II");
}
else Console.WriteLine("Obesidade III");

Console.WriteLine("---------------------------------------------------------");

float calc, fnum, snum, tnum;
Console.WriteLine("2. Desenvolva uma aplicação que exiba a média de 3 numero e o nome do usuário.");
Console.Write("Insira seu nome: ");
string name = Console.ReadLine();
Console.Write("Insira o primeiro número: ");
fnum = float.Parse(Console.ReadLine());
Console.Write("Insira o segundo número: ");
snum = float.Parse(Console.ReadLine());
Console.Write("Insira o terceiro número: ");
tnum = float.Parse(Console.ReadLine());

calc = (fnum + snum + tnum)/ 3;
Console.WriteLine("Seu nome é: " + name);
Console.WriteLine("A media dos valores é: " + calc);


