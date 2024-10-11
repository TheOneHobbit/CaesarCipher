using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
      Console.Write("What is your message?: ");
      string input = Console.ReadLine();
      if (input == null) return;
      input = input.ToLower();
      char[] secretMessage = input.ToCharArray();

      char[] encryptedMessage = new char[secretMessage.Length];

      for (int i = 0; i < secretMessage.Length; i++) {
        char letter = secretMessage[i];
        int letterPosition = Array.IndexOf(alphabet, letter);
        if (letterPosition == -1)
        {
            encryptedMessage[i] = letter; // Keep the original letter if not in the alphabet
            continue; // Skip the rest of the loop iteration
        }
        int newLetterPosition = (letterPosition + 3) % alphabet.Length;
        char letterEncoded = alphabet[newLetterPosition];
        encryptedMessage[i] = letterEncoded;
      }
      string encodedString = String.Join("", encryptedMessage);
      Console.WriteLine($"Your message is: {encodedString}");
    }
  }
}