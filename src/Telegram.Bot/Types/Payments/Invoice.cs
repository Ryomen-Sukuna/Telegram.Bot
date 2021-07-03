using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.Bot.Types.Payments
{
    /// <summary>
    /// This object contains basic information about an invoice.
    /// </summary>
    /// <seealso href="https://core.telegram.org/bots/api#invoice"/>
    [JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class Invoice
    {
        /// <summary>
        /// Product name
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public string Title { get; set; }

        /// <summary>
        /// Product description
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public string Description { get; set; }

        /// <summary>
        /// Unique bot deep-linking parameter that can be used to generate this invoice
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public string StartParameter { get; set; }

        /// <summary>
        /// Three-letter ISO 4217 <see href="https://core.telegram.org/bots/payments#supported-currencies">currency</see> code
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public string Currency { get; set; }

        /// <summary>
        /// Total price in the <i>smallest units</i> of the <see href="https://core.telegram.org/bots/payments#supported-currencies">currency</see> (integer, <b>not</b> float/double).
        /// <para>For example, for a price of <c>US$ 1.45</c> pass <c>amount = 145</c>. See the <i>exp</i> parameter in <see href="https://core.telegram.org/bots/payments/currencies.json">currencies.json</see>, it shows the number of digits past the decimal point for each currency (2 for the majority of currencies).</para>
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public int TotalAmount { get; set; }
    }
}
