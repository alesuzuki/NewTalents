using NewTalents;

Calculadora calc = new Calculadora();

int val1 = 1, val2 = 3;
calc.somar(val1, val2);


val1 = 2;
val2 = 3;
calc.somar(val1, val2);


val1 = 6;
val2 = 4;
calc.subtrair(val1, val2);


val1 = 6;
val2 = 3;
calc.multiplicar(val1, val2);

val1 = 2;
val2 = 5;
calc.dividir(val1, val2);

try
{
    var lista = calc.Historico();
    foreach (var item in lista)
        Console.WriteLine(item.ToString());
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}
