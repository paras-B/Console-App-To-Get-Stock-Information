using System;
using System.Text.Json.Serialization;

namespace ConsoleAppStockPriceGetter
{
    public class TickerSymbolBasicFinancial
    {
        [JsonPropertyName("metric")]
        public Metric metric { get; set; }
        
        [JsonPropertyName("metricType")]
        public string metricType { get; set; }
        
        [JsonPropertyName("series")]
        public Series series { get; set; }
        
        [JsonPropertyName("symbol")]
        public string symbol { get; set; }
    }

    public class Metric
    {
        [JsonPropertyName("_10DayAverageTradingVolume")]
        public float _10DayAverageTradingVolume { get; set; }
        
        [JsonPropertyName("_13WeekPriceReturnDaily")]
        public float _13WeekPriceReturnDaily { get; set; }
        
        /*
        public float _26WeekPriceReturnDaily { get; set; }
        public float _3MonthAverageTradingVolume { get; set; }
        public float _52WeekHigh { get; set; }
        public string _52WeekHighDate { get; set; }
        public float _52WeekLow { get; set; }
        public string _52WeekLowDate { get; set; }
        public float _52WeekPriceReturnDaily { get; set; }
        public float _5DayPriceReturnDaily { get; set; }
        public float assetTurnoverAnnual { get; set; }
        public float assetTurnoverTTM { get; set; }
        public float beta { get; set; }
        public float bookValuePerShareAnnual { get; set; }
        public float bookValuePerShareQuarterly { get; set; }
        public float bookValueShareGrowth5Y { get; set; }
        public float capitalSpendingGrowth5Y { get; set; }
        public float cashFlowPerShareAnnual { get; set; }
        public float cashFlowPerShareTTM { get; set; }
        public float cashPerSharePerShareAnnual { get; set; }
        public float cashPerSharePerShareQuarterly { get; set; }
        public float currentDividendYieldTTM { get; set; }
        public float currentEvfreeCashFlowAnnual { get; set; }
        public float currentEvfreeCashFlowTTM { get; set; }
        public float currentRatioAnnual { get; set; }
        public float currentRatioQuarterly { get; set; }
        public float dividendGrowthRate5Y { get; set; }
        public float dividendPerShare5Y { get; set; }
        public float dividendPerShareAnnual { get; set; }
        public float dividendYield5Y { get; set; }
        public float dividendYieldIndicatedAnnual { get; set; }
        public float dividendsPerShareTTM { get; set; }
        public float ebitdPerShareTTM { get; set; }
        public float ebitdaCagr5Y { get; set; }
        public float ebitdaInterimCagr5Y { get; set; }
        public float epsBasicExclExtraItemsAnnual { get; set; }
        public float epsBasicExclExtraItemsTTM { get; set; }
        public float epsExclExtraItemsAnnual { get; set; }
        public float epsExclExtraItemsTTM { get; set; }
        public float epsGrowth3Y { get; set; }
        public float epsGrowth5Y { get; set; }
        public float epsGrowthQuarterlyYoy { get; set; }
        public float epsGrowthTTMYoy { get; set; }
        public float epsInclExtraItemsAnnual { get; set; }
        public float epsInclExtraItemsTTM { get; set; }
        public float epsNormalizedAnnual { get; set; }
        public float focfCagr5Y { get; set; }
        public int freeCashFlowAnnual { get; set; }
        public float freeCashFlowPerShareTTM { get; set; }
        public int freeCashFlowTTM { get; set; }
        public float freeOperatingCashFlowrevenue5Y { get; set; }
        public float freeOperatingCashFlowrevenueTTM { get; set; }
        public float grossMargin5Y { get; set; }
        public float grossMarginAnnual { get; set; }
        public float grossMarginTTM { get; set; }
        public float inventoryTurnoverAnnual { get; set; }
        public float inventoryTurnoverTTM { get; set; }
        public float longTermDebtequityAnnual { get; set; }
        public float longTermDebtequityQuarterly { get; set; }
        public int marketCapitalization { get; set; }
        public float monthToDatePriceReturnDaily { get; set; }
        public int netDebtAnnual { get; set; }
        public int netDebtInterim { get; set; }
        public float netIncomeEmployeeAnnual { get; set; }
        public int netIncomeEmployeeTTM { get; set; }
        public object netInterestCoverageAnnual { get; set; }
        public object netInterestCoverageTTM { get; set; }
        public float netMarginGrowth5Y { get; set; }
        public float netProfitMargin5Y { get; set; }
        public float netProfitMarginAnnual { get; set; }
        public float netProfitMarginTTM { get; set; }
        public float operatingMargin5Y { get; set; }
        public float operatingMarginAnnual { get; set; }
        public float operatingMarginTTM { get; set; }
        public float payoutRatioAnnual { get; set; }
        public float payoutRatioTTM { get; set; }
        public float pbAnnual { get; set; }
        public float pbQuarterly { get; set; }
        public float pcfShareTTM { get; set; }
        public float peBasicExclExtraTTM { get; set; }
        public float peExclExtraAnnual { get; set; }
        public float peExclExtraHighTTM { get; set; }
        public float peExclExtraTTM { get; set; }
        public float peExclLowTTM { get; set; }
        public float peInclExtraTTM { get; set; }
        public float peNormalizedAnnual { get; set; }
        public float pfcfShareAnnual { get; set; }
        public float pfcfShareTTM { get; set; }
        public float pretaxMargin5Y { get; set; }
        public float pretaxMarginAnnual { get; set; }
        public float pretaxMarginTTM { get; set; }
        public float priceRelativeToSP50013Week { get; set; }
        public float priceRelativeToSP50026Week { get; set; }
        public float priceRelativeToSP5004Week { get; set; }
        public float priceRelativeToSP50052Week { get; set; }
        public float priceRelativeToSP500Ytd { get; set; }
        public float psAnnual { get; set; }
        public float psTTM { get; set; }
        public float ptbvAnnual { get; set; }
        public float ptbvQuarterly { get; set; }
        public float quickRatioAnnual { get; set; }
        public float quickRatioQuarterly { get; set; }
        public float receivablesTurnoverAnnual { get; set; }
        public float receivablesTurnoverTTM { get; set; }
        public int revenueEmployeeAnnual { get; set; }
        public int revenueEmployeeTTM { get; set; }
        public float revenueGrowth3Y { get; set; }
        public float revenueGrowth5Y { get; set; }
        public float revenueGrowthQuarterlyYoy { get; set; }
        public float revenueGrowthTTMYoy { get; set; }
        public float revenuePerShareAnnual { get; set; }
        public float revenuePerShareTTM { get; set; }
        public float revenueShareGrowth5Y { get; set; }
        public float roaRfy { get; set; }
        public float roaa5Y { get; set; }
        public float roae5Y { get; set; }
        public float roaeTTM { get; set; }
        public float roeRfy { get; set; }
        public float roeTTM { get; set; }
        public float roi5Y { get; set; }
        public float roiAnnual { get; set; }
        public float roiTTM { get; set; }
        public float tangibleBookValuePerShareAnnual { get; set; }
        public float tangibleBookValuePerShareQuarterly { get; set; }
        public float tbvCagr5Y { get; set; }
        public float totalDebttotalEquityAnnual { get; set; }
        public float totalDebttotalEquityQuarterly { get; set; }
        public float totalDebtCagr5Y { get; set; }
        public float yearToDatePriceReturnDaily { get; set; }
        */
    }

    public class Series
    {
        public Annual annual { get; set; }
    }

    public class Annual
    {
        public Cashratio[] cashRatio { get; set; }
        public Currentratio[] currentRatio { get; set; }
        public Ebitpershare[] ebitPerShare { get; set; }
        public Ep[] eps { get; set; }
        public Grossmargin[] grossMargin { get; set; }
        public Longtermdebttotalasset[] longtermDebtTotalAsset { get; set; }
        public Longtermdebttotalcapital[] longtermDebtTotalCapital { get; set; }
        public Longtermdebttotalequity[] longtermDebtTotalEquity { get; set; }
        public Netdebttototalcapital[] netDebtToTotalCapital { get; set; }
        public Netdebttototalequity[] netDebtToTotalEquity { get; set; }
        public Netmargin[] netMargin { get; set; }
        public Operatingmargin[] operatingMargin { get; set; }
        public Pretaxmargin[] pretaxMargin { get; set; }
        public Salespershare[] salesPerShare { get; set; }
        public Sgatosale[] sgaToSale { get; set; }
        public Totaldebttoequity[] totalDebtToEquity { get; set; }
        public Totaldebttototalasset[] totalDebtToTotalAsset { get; set; }
        public Totaldebttototalcapital[] totalDebtToTotalCapital { get; set; }
        public Totalratio[] totalRatio { get; set; }
    }

    public class Cashratio
    {
        public string period { get; set; }
        public float v { get; set; }
    }

    public class Currentratio
    {
        public string period { get; set; }
        public float v { get; set; }
    }

    public class Ebitpershare
    {
        public string period { get; set; }
        public float v { get; set; }
    }

    public class Ep
    {
        public string period { get; set; }
        public float v { get; set; }
    }

    public class Grossmargin
    {
        public string period { get; set; }
        public float v { get; set; }
    }

    public class Longtermdebttotalasset
    {
        public string period { get; set; }
        public float v { get; set; }
    }

    public class Longtermdebttotalcapital
    {
        public string period { get; set; }
        public float v { get; set; }
    }

    public class Longtermdebttotalequity
    {
        public string period { get; set; }
        public float v { get; set; }
    }

    public class Netdebttototalcapital
    {
        public string period { get; set; }
        public float v { get; set; }
    }

    public class Netdebttototalequity
    {
        public string period { get; set; }
        public float v { get; set; }
    }

    public class Netmargin
    {
        public string period { get; set; }
        public float v { get; set; }
    }

    public class Operatingmargin
    {
        public string period { get; set; }
        public float v { get; set; }
    }

    public class Pretaxmargin
    {
        public string period { get; set; }
        public float v { get; set; }
    }

    public class Salespershare
    {
        public string period { get; set; }
        public float v { get; set; }
    }

    public class Sgatosale
    {
        public string period { get; set; }
        public float v { get; set; }
    }

    public class Totaldebttoequity
    {
        public string period { get; set; }
        public float v { get; set; }
    }

    public class Totaldebttototalasset
    {
        public string period { get; set; }
        public float v { get; set; }
    }

    public class Totaldebttototalcapital
    {
        public string period { get; set; }
        public float v { get; set; }
    }

    public class Totalratio
    {
        public string period { get; set; }
        public float v { get; set; }
    }
}

