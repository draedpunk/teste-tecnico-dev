using teste_tecnico_even3.Models;

// NUMEROS UNICOS ------------------------------
int[] numeros = { 1, 2, 2, 4, 5, 5, 8, 8 };
Console.WriteLine("Números únicos:");
NumerosNaoRepetidos.ExibirNumerosUnicos(numeros);

//VALIDADOR DE EMAIL -------------------------------
string emailPamela = "pamdela@yahoo.com";
Console.WriteLine("Validador de e-mail:");
Console.WriteLine(ValidadorEmail.VerificarEmail(emailPamela)); // valido
// string outroEmailInvalido = "edgar.allanpoe";
string outroEmailInvalido = "keanu@reeves";
Console.WriteLine(ValidadorEmail.VerificarEmail(outroEmailInvalido)); // invalido

// SOMA ATÉ N -------------------------------
int nume = 25;
Console.WriteLine("Soma de 1 até " + nume+ ":");
Console.WriteLine(Somatorio.SomarTodosOsNumeros(nume));

// INVERSOR DE STRING -------------------------------
Console.WriteLine("Inversor de string:");
string b = "even3";
Console.WriteLine(Inverter.InverterTexto(b));