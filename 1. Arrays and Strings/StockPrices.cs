using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI._1._Arrays_and_Strings
{
    // Given Stock prices as [9,2,5,6,6,1,3,7], Say each index is a year, in increasing order 
    // Which year should I buy and sell. Get Index of array.
    // Output Buy at price 1 and sell at 7
    public class StockPrices
    {
        public static BuySell MaxProfitValuesNaive(int[] array)
        {
            int maxProfit = 0;
            BuySell buySellValues = new BuySell();
            buySellValues.Buy = array[0];

            for (int i = 0; i < array.Length; i++)
            {

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < buySellValues.Buy && array[j] - array[i] > maxProfit)
                    {
                        maxProfit = array[j] - array[i];
                        buySellValues.Buy = array[i];
                        buySellValues.Sell = array[j];
                    }
                }
            }
            return buySellValues;
        }

        public static BuySell MaxProfitIndexesNaive(int[] array)
        {
            int maxProfit = 0;
            BuySell buySellIndexes = new BuySell();
            buySellIndexes.Buy = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[buySellIndexes.Buy] && array[j] - array[i] > maxProfit)
                    {
                        maxProfit = array[j] - array[i];
                        buySellIndexes.Buy = i;
                        buySellIndexes.Sell = j;
                    }
                }
            }
            return buySellIndexes;
        }


        public static BuySell MaxProfitIndexes(int[] array)
        {
            int maxProfit = 0;
            BuySell buySellValues = new BuySell();
            buySellValues.Buy = array[0];
            int minIndex = 0;

            BuySell buySellIndexes = new BuySell();
            buySellIndexes.Buy = 0;
            buySellIndexes.Sell = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] - buySellValues.Buy > maxProfit)
                {
                    maxProfit = array[i] - buySellValues.Buy;
                    buySellValues.Sell = array[i];

                    buySellIndexes.Sell = i;
                    buySellIndexes.Buy = minIndex;
                }

                // Dont update buy index here, only minIndex variable. As BuyIndex should be updated only if profit is max too
                if (buySellValues.Buy > array[i])
                {
                    buySellValues.Buy = array[i];
                    minIndex = i;
                }

            }
            return buySellIndexes;
        }

        public struct BuySell
        {
            public int Buy { get; set; }
            public int Sell { get; set; }
        }
    }
}
