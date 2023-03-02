using Lab1_David_Steward_Sibrian_Gomez.Entidades;
using Lab1_David_Steward_Sibrian_Gomez.Negocio;
using System.Drawing;


Persona persona = new Persona();
ClsPersona clsPersona = new ClsPersona(); 


Console.WriteLine("Ingrese su nombre");
string Nombre = Console.ReadLine();


Console.WriteLine("Ingrese su edad");
string Edad = Console.ReadLine();
int E = Convert.ToInt32(Edad);


Console.WriteLine("Ingrese su sexo, M(Hombre), F(Mujer)");
string Sexo = Console.ReadLine();


Console.WriteLine("Ingrese su peso");
string Peso = Console.ReadLine();
int P = Convert.ToInt32(Peso);


Console.WriteLine("Ingrese su altura");
string Altura = Console.ReadLine();
double A = Convert.ToDouble(Altura);


persona.Nombre = Nombre;
persona.Edad = E;
persona.Peso = P;
persona.Altura = A;


String Resultado = ClsPersona.calcularIMC(persona);
Console.WriteLine(Resultado);


String Result = ClsPersona.EsMayorDeEdad(persona);
Console.WriteLine(Result);

