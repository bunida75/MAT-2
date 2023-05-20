class Program
{
    static void Main()
    {
        bool continueProgram = true;

        while (continueProgram)
        {
            Console.WriteLine("Enter half DNA sequence:");
            string input = Console.ReadLine();

            if (IsValidSequence(input))
            {
                Console.WriteLine("Current half DNA sequence: " + input);

                Console.Write("Do you want to replicate it? (Y/N): ");
                string choice = Console.ReadLine();

                if (choice.ToUpper() == "Y")
                {
                    string replicatedSequence = ReplicateSequence(input);
                    Console.WriteLine("Replicated half DNA sequence: " + replicatedSequence);
                }
                else if (choice.ToUpper() == "N")
                {
                    // Skip replication
                }
                else
                {
                    Console.WriteLine("Please input Y or N.");
                    continue;
                }
            }
            else
            {
                Console.WriteLine("That half DNA sequence is invalid.");
            }

            Console.Write("Do you want to process another sequence? (Y/N): ");
            string restartChoice = Console.ReadLine();

            if (restartChoice.ToUpper() == "Y")
            {
                // Continue the program
            }
            else if (restartChoice.ToUpper() == "N")
            {
                continueProgram = false;
            }
            else
            {
                Console.WriteLine("Please input Y or N.");
            }
        }
    }

    static bool IsValidSequence(string halfDNASequence)
    {
        foreach (char nucleotide in halfDNASequence)
        {
            if (!"ATCG".Contains(nucleotide))
            {
                return false;
            }
        }
        return true;
    }

    static string ReplicateSequence(string halfDNASequence)
    {
        string result = "";
        foreach (char nucleotide in halfDNASequence)
        {
            result += "TAGC"["ATCG".IndexOf(nucleotide)];
        }
        return result;
    }
}