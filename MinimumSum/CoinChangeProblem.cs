using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumSum
{

    public class CoinChangeProblem
    {
        public CoinChangeProblem() { }

        public int CoinChange(int[] coins, int amount)
        {
            int[] dp = new int[amount + 1];
            Array.Fill(dp, amount + 1);
            dp[0] = 0;

            for (int i = 1; i <= amount; i++)
            {
                foreach (int coin in coins)
                {
                    if (i - coin >= 0)
                    {
                        dp[i] = Math.Min(dp[i], dp[i - coin] + 1);
                    }
                }
            }

            return dp[amount] > amount ? -1 : dp[amount];
        }

        public static void CoinChangeMain()
        {
            CoinChangeProblem ccp = new CoinChangeProblem();
            int[] coins = { 1, 2, 5 };
            int amount = 11;
            int result = ccp.CoinChange(coins, amount);
            Console.WriteLine(result == -1 ? "No solution" : $"Minimum coins needed: {result}");
        }
    }



}
