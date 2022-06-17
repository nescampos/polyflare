namespace KlaytonWeb.Models
{
    public class TokenBalanceDTO
    {
        public TokenBalanceDTOData data { get; set; }
        public bool error { get; set; }
        public string? error_message { get; set; }
        public int? error_code { get; set; }
    }

    public class TokenBalanceDTOData
    {
        public string address { get; set; }
        public string updated_at { get; set; }
        public string next_update_at { get; set; }
        public string quote_currency { get; set; }
        public int chain_id { get; set; }
        public List<TokenBalanceDTOItem> items { get; set; }
        public object pagination { get; set; }
    }

    public class TokenBalanceDTOItem
    {
        public int contract_decimals { get; set; }
        public string contract_name { get; set; }
        public string contract_ticker_symbol { get; set; }
        public string contract_address { get; set; }
        public List<string> supports_erc { get; set; }
        public string logo_url { get; set; }
        public DateTime? last_transferred_at { get; set; }
        public string type { get; set; }
        public string balance { get; set; }
        public string balance_24h { get; set; }
        public double quote_rate { get; set; }
        public double? quote_rate_24h { get; set; }
        public double quote { get; set; }
        public double? quote_24h { get; set; }
        public object nft_data { get; set; }
    }
}
