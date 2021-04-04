using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleAppStockPriceGetter
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            do
            {
                //Welcome Message 
                Console.WriteLine("***************************************");
                Console.WriteLine("Welcome to Console App Stock Information Getter \n" +
                "Please read the following Instruction and Press the approproate key from your keyboard");
                Console.WriteLine();
                Console.WriteLine("To get Price of a particular stock, Press key 'Q' \n" +
                    "To search for best-matching symbols based on your query. You can input anything from symbol, security's name to ISIN and Cusip; Press  key 'S' \n" +
                    "To get company basic financials such as margin, P/E ratio, 52-week high/low etc; Press key 'B' \n" +
                    "To Exit this application, Press 'Esc' key"
                    );

                string mainKeywordEntry = Console.ReadLine();
                if (mainKeywordEntry == "Q")
                {
                    //Getting Quote from Stock Ticker Symbol
                    Console.Write("Please enter the ticker symbol of stock you would like to view the prices : ");
                    string tickerSymbol = Console.ReadLine();
                    ShowQuoteOfTickerSymbol(tickerSymbol);
                    //empty line
                    Console.WriteLine();
                    Console.WriteLine("Press Enter Key to Proceed or Esc to Exit");
                }
                else if (mainKeywordEntry == "S")
                {
                    //Getting Information related to ticker symbol
                    Console.Write("Search for best-matching symbols based on your query. You can input anything from symbol, security's name to ISIN and Cusip. : ");
                    string querySymbolLookUp = Console.ReadLine();
                    ShowStockTickerSymbolInfo(querySymbolLookUp);
                    //empty line
                    Console.WriteLine();
                    Console.WriteLine("Press Enter Key to Proceed or Esc to Exit");
                }

                else if(mainKeywordEntry == "B")
                {
                    Console.Write("To get company basic financials such as margin, P/E ratio, 52-week high/low etc; : ");
                    string tickerSymbol = Console.ReadLine();
                    ShowBasicFinancialForTicker(tickerSymbol);
                    //empty line
                    Console.WriteLine();
                    Console.WriteLine("Press Enter Key to Proceed or Esc to Exit");
                }

                while(Console.KeyAvailable == false)
                {
                    Thread.Sleep(250);
                }
                cki = Console.ReadKey(true);
            } while (cki.Key != ConsoleKey.Escape);
        }
        private static void ShowStockTickerSymbolInfo(string querySymbolLookUp)
        {
            var response = StockInfo.GetStockSymbolInfo(querySymbolLookUp);

            SymbolLookUpResult[] symbolLookUp = response.result;

            foreach(var stockinfo in symbolLookUp)
            {
                Console.WriteLine(stockinfo.description);
                Console.WriteLine(stockinfo.displaySymbol);
                Console.WriteLine(stockinfo.symbol);
                Console.WriteLine(stockinfo.type);
                Console.WriteLine();
            }
        }

        private static void ShowQuoteOfTickerSymbol(string tickerSymbol)
        {
            var quoteResponse = StockInfo.GetQuoteOfStockSymbol(tickerSymbol);

            Console.WriteLine($"Curent price of {tickerSymbol} is {quoteResponse.c}");
            Console.WriteLine($"Open price of {tickerSymbol} is {quoteResponse.o}");
            Console.WriteLine($"High price of {tickerSymbol} is {quoteResponse.h}");
            Console.WriteLine($"Low price of {tickerSymbol} is {quoteResponse.l}");
            Console.WriteLine($"Previous Day close price of {tickerSymbol} is {quoteResponse.pc}");
            
        }

        private static void ShowBasicFinancialForTicker(string tickerSymbol)
        {
            var metricResponse = StockInfo.GetTickerSymbolBasicFinancial(tickerSymbol);

            //Annaul metrics for that particular ticker
            Metric metricResponseAnnual = metricResponse.metric;
            Console.WriteLine(metricResponseAnnual._10DayAverageTradingVolume);
            Console.WriteLine(metricResponseAnnual._13WeekPriceReturnDaily);



            Series seriesInfoForTicker = metricResponse.series;
            Annual AnnualInfoForTicker = seriesInfoForTicker.annual;
            
            //Cash Ratio
            Cashratio[] cashRatioForTicker = AnnualInfoForTicker.cashRatio;
            Console.WriteLine("Period , Value");
            foreach (var cashratio in cashRatioForTicker)
            {
                Console.WriteLine($"{cashratio.period}, {cashratio.v}");
            }

            //Ebit Per Share
            Ebitpershare[] ebitPerShareForTicker = AnnualInfoForTicker.ebitPerShare;
            Console.WriteLine();
            Console.WriteLine("EbitPerShare");
            Console.WriteLine("Period , Value");
            foreach (var ebitPerShare in ebitPerShareForTicker)
            {
                Console.WriteLine($"{ebitPerShare.period}, {ebitPerShare.v}");
            }
        }
    }
}
