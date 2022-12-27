using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal  class NotesVendingMachine
    {
        public static int[] notes = new int[] { 1, 2, 5, 10, 50, 100, 500, 1000 };
        public static int[] numofNotes = new int[8];
        public static int notesCount = 0;
        public static void GetNotes()
        {
            Console.WriteLine("\nEnter the amount to be returned by the vending machine;");
            int amount = Convert.ToInt32(Console.ReadLine());

            for(int i =0;i < numofNotes.Length; i++)
            {
                if(amount >= notes[i])
                {
                    numofNotes[i] = amount / notes[i];
                    amount =amount - numofNotes[i] * notes[i];
                    notesCount++;
                }
            }
            for (int i =0;i < numofNotes.Length; i++)
            {
                if (numofNotes[i] != 0)
                {
                    Console.WriteLine(notes[i] + " * " + numofNotes[i] + " = " + (notes[i] * numofNotes[i]));
                }
            }
            Console.WriteLine("Minimum number of notes: " + notesCount);
        }

    }
}
