
Console.WriteLine("Inserisci una parola:");
string inputUtente = Console.ReadLine();

if (IsPalindromo(inputUtente)){
    Console.WriteLine($"{inputUtente} è un Palindromo");
}
else
{
    Console.WriteLine($"{inputUtente} non è un Palindromo");

}

bool IsPalindromo (string s)
{
    string verifica = new string(s.Where(c => !char.IsWhiteSpace(c)).ToArray()).ToLower();

    return verifica.SequenceEqual(verifica.Reverse());
}
