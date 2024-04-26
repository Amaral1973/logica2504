using static System.Console;

int num, resultado;

WriteLine(">>>> TABUADA <<<<");
WriteLine("Digite um número inteiro:");
num  = Convert.ToInt32(ReadLine());

for (int i = 1; i <= 10; i++)
{
    resultado = num * i;
    WriteLine(num + " X " + i + " = " + resultado.ToString());
}