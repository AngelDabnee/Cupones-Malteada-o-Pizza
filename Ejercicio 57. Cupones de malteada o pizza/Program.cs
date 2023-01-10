// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Ciclo para capturar las edades de 13 niños," +
    "si cada uno de ellos tiene menos+ " +
    "de 9 años, imprime cupón para malteada, si alguno de los+ " +
    "niños es mayor a 13 años, imprime vale por PIZZA.");
//Datos de entrada
int[]edades= new int[13];
for (int i = 0; i < edades.Length; i++)
{
    Console.WriteLine("Captura la edad del niño No. " + (i+1));//Capturar la edad de cada niño
    edades[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < edades.Length; i++)//Realizar las operaciones
{
    if (edades[i] < 9)//Operación para darles su vale de malteada
    {
        Console.WriteLine("Vale por Malteada");
    }
    if (edades[i]>13)//Operación para su vale de pizza
    {
        Console.WriteLine("Vale por pizza");
    }
    if (edades[i] >= 9 && edades[i] <= 13)//Si no es uno u otro, pues no son dignos
    {
        Console.WriteLine("Vuelve cuando seas digno");
    }
}