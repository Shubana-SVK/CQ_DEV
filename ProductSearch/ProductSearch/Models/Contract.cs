//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProductSearch.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contract
    {
        public string Com_Type { get; set; }
        public string Exch_Cd { get; set; }
        public string Com_Cd { get; set; }
        public string Contract_Mon_Type { get; set; }
        public decimal Val_Per_Pt { get; set; }
        public byte Factor { get; set; }
        public int Strike_Price_Decimal { get; set; }
        public Nullable<int> Exch_Decimal { get; set; }
        public string Settle_Curr_Cd { get; set; }
        public string Comm_Curr_Cd { get; set; }
        public string Margin_Curr_Cd { get; set; }
        public string OutrightMarginType { get; set; }
        public Nullable<decimal> SpotIM { get; set; }
        public Nullable<decimal> SpotMM { get; set; }
        public Nullable<decimal> NonSpotIM { get; set; }
        public Nullable<decimal> NonSpotMM { get; set; }
        public string Smx_Com_Cd { get; set; }
        public string Pats_Exch_Cd { get; set; }
        public string Pats_Com_Cd { get; set; }
        public string Pats_Cont_Type { get; set; }
        public int Pats_Decimal { get; set; }
        public string Span_Exch_Cd { get; set; }
        public string Span_Com_Cd { get; set; }
        public Nullable<int> Span_Decimal { get; set; }
        public string Span_Comb_Com_Cd { get; set; }
        public string Span_Return_Comb_Com_Cd { get; set; }
        public string SpanProductType { get; set; }
        public string Poems_Exch_Cd { get; set; }
        public string Poems_Com_Cd { get; set; }
        public Nullable<int> Poems_Decimal { get; set; }
        public string Contract_Nature { get; set; }
        public string MOS_Ind { get; set; }
        public string Reuters_Exch_Cd { get; set; }
        public string Reuters_Com_Cd { get; set; }
        public Nullable<int> Reuters_Decimal { get; set; }
        public Nullable<decimal> Reuters_Decimal_Division { get; set; }
        public string Calyon_Exch_Cd { get; set; }
        public string Calyon_Com_Cd { get; set; }
        public Nullable<int> Calyon_Decimal { get; set; }
        public Nullable<int> OptExch_Decimal { get; set; }
        public string GL_Exch_Cd { get; set; }
        public string GL_Com_Cd { get; set; }
        public Nullable<int> GL_Decimal { get; set; }
        public string TT_Exch_Cd { get; set; }
        public string TT_Com_Cd { get; set; }
        public Nullable<int> TT_Decimal { get; set; }
        public string TT_Net_Gateway { get; set; }
        public Nullable<int> TT_Premium_Decimal { get; set; }
        public string MarginMethod { get; set; }
        public string PatsBOAExchCd { get; set; }
        public string Pats_Spread_Com_Cd { get; set; }
        public string Created_By { get; set; }
        public Nullable<System.DateTime> Created_Datetime { get; set; }
        public string Modified_By { get; set; }
        public Nullable<System.DateTime> Modified_Datetime { get; set; }
        public string OPEN_OUTCRY_CODE { get; set; }
        public string OPTION_EXERCISE_STYLE { get; set; }
        public Nullable<int> LARGE_TRADER_RPTLIMIT { get; set; }
        public string Large_Trader_ExchID { get; set; }
        public Nullable<int> LTR_StrikePrice_Decimal { get; set; }
        public Nullable<int> CFTC_RptLimit { get; set; }
        public string CFTC_ExchID { get; set; }
        public Nullable<int> CFTC_StrikePrice_Decimal { get; set; }
        public Nullable<int> CFTC_Volume_Limit { get; set; }
        public Nullable<int> Reuters_Premium_Decimal { get; set; }
        public Nullable<int> Reuters_StrikePrice_Decimal { get; set; }
        public string CQG_Exch_Cd { get; set; }
        public string CQG_Com_Cd { get; set; }
        public Nullable<int> CQG_Decimal { get; set; }
        public Nullable<int> CQG_Premium_Decimal { get; set; }
        public string PCS_Com_Cd { get; set; }
        public string OptionMarkToMarket { get; set; }
        public string CTS_Exch_Cd { get; set; }
        public string CTS_Com_Cd { get; set; }
        public Nullable<int> CTS_Decimal { get; set; }
        public Nullable<int> CTS_Premium_Decimal { get; set; }
        public string NFA_Curr_Cd { get; set; }
        public Nullable<int> RIC_StrikePrice_Decimal { get; set; }
        public string Rithimic_Exch_Cd { get; set; }
        public string Rithimic_Com_Cd { get; set; }
        public Nullable<int> Rithimic_Decimal { get; set; }
        public Nullable<int> Rithimic_Premium_Decimal { get; set; }
        public Nullable<int> CME_Volume_Limit { get; set; }
        public Nullable<decimal> TickData { get; set; }
        public string CME_Exch_Cd { get; set; }
        public string CME_Com_Cd { get; set; }
        public Nullable<int> CME_Decimal { get; set; }
        public Nullable<int> CME_Premium_Decimal { get; set; }
        public Nullable<int> Pats_Prem_Decimal { get; set; }
        public string GlbxCd { get; set; }
        public Nullable<int> GlbxOptPriceDecimal { get; set; }
        public Nullable<int> GlbxOptPriceDecimalLen { get; set; }
        public string Reuters_Intraday_Com_Cd { get; set; }
        public string IRB_Com_cd { get; set; }
        public Nullable<int> IRB_Strike_Price_Decimal { get; set; }
        public string ADM_Exch_Cd { get; set; }
        public string ADM_Com_Cd { get; set; }
        public Nullable<int> ADM_Strike_Price_Decimal { get; set; }
        public string LongRptPostion { get; set; }
        public string Price_Quotation { get; set; }
        public string Price_Quotation_Desc { get; set; }
        public Nullable<decimal> Face_Value { get; set; }
        public Nullable<int> Days_To_Maturity { get; set; }
        public Nullable<decimal> Coupon_Rate { get; set; }
        public Nullable<int> Payable_Dividends { get; set; }
        public string ICESPAN_Exch_Cd { get; set; }
        public string ICESPAN_Return_Comb_Com_Cd { get; set; }
        public string MIC_Cd { get; set; }
        public string Commodity_base { get; set; }
    }
}
