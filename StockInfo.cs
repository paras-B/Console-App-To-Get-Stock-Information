using System;

namespace ConsoleAppStockPriceGetter
{
	public static class StockInfo
	{
		const string url = "https://finnhub.io/api/v1/";
		const string apiKey = "YourAPIKey";

		//This method gets the Information related to ticker symbol
		public static SymbolLookUp GetStockSymbolInfo(string querySymbolLookUp)
		{
			string urlParameters = $"search?q={querySymbolLookUp}&token={apiKey}";
			var response = APICall.RunAsync<SymbolLookUp>(url, urlParameters).GetAwaiter().GetResult();
			return response;
		}

		//This method gets the Quote of ticker symbol of a stock
		public static QuoteLookUpSymbol GetQuoteOfStockSymbol(string tickerSymbol)
		{
			string urlParameters = $"quote?symbol={tickerSymbol}&token={apiKey}";
			var quoteResponse = APICall.RunAsync<QuoteLookUpSymbol>(url, urlParameters).GetAwaiter().GetResult();
			return quoteResponse;
		}

		//This method gets the basic financials of a company when a ticker symbol is passed.
		public static TickerSymbolBasicFinancial GetTickerSymbolBasicFinancial(string tickerSymbol)
		{
			string urlParameters = $"stock/metric?symbol={tickerSymbol}&metric=all&token={apiKey}";
			var metricResponse = APICall.RunAsync<TickerSymbolBasicFinancial>(url, urlParameters).GetAwaiter().GetResult();
			return metricResponse;
		}

	}
}

