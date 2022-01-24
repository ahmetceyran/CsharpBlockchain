using System;
using Sharpchain.Model;

namespace Sharpchain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "# Sharpchain by Felony #";

            const int difficulty = 1;
            int numberOfBlocksToMine = 4;

            var blockchain = new Blockchain.Blockchain(difficulty);

            for (int i = 1; i <= numberOfBlocksToMine; i++)
            {
                try
                {

                    IBlock minedBlock = blockchain.Mine($"Ali Veli ");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine();
            foreach (IBlock block in blockchain)
            {
                Console.WriteLine("Time : " + block.TimeStamp.ToString() + "\n" + "Index : "+ block.Index + "\n" + "Nonce : " + block.Nonce + "\n" + "Data : " + block.Data + "\n" + "Hash : " + block.Hash + "\n" + "Previous Hash : " + block.PrevHash + "\n");
            }

            Console.Read();
        }
    }
}