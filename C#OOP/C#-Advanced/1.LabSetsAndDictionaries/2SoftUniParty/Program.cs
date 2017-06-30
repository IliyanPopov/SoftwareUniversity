namespace _2SoftUniParty
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            HashSet<string> invitations = new HashSet<string>();

            while (input != "PARTY")
            {
                string invitationNumber = input;
                invitations.Add(invitationNumber);

                input = Console.ReadLine();
            }

            string input2 = Console.ReadLine();
            while (input2 != "END")
            {
                string invitationNumberAccepted = input2;

                if (invitations.Contains(invitationNumberAccepted))
                {
                    invitations.Remove(invitationNumberAccepted);
                }
                input2 = Console.ReadLine();
            }

            Console.WriteLine(invitations.Count);

            var sortedInvitations = invitations.OrderBy(x => x);

            foreach (var invitation in sortedInvitations)
            {
                Console.WriteLine(invitation);
            }
        }
    }
}