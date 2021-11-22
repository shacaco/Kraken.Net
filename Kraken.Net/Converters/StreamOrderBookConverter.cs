using System.Collections.Generic;
using Kraken.Net.Objects;
using Kraken.Net.Objects.Socket;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Kraken.Net.Converters
{
    internal static class StreamOrderBookConverter
    {
        public static void Populate(JArray arr, KrakenSocketEvent<KrakenStreamOrderBook> obj, JsonSerializer serializer)
        {
            obj.ChannelId = (int)arr[0];
           
            obj.Data.Bids.Clear();
            obj.Data.Asks.Clear();

            if (arr.Count == 4)
            {
                var innerObject = arr[1];
                if (innerObject["as"] != null)
                {
                    // snapshot
                    innerObject["as"].Populate(obj.Data.Asks, serializer); 
                    innerObject["bs"].Populate(obj.Data.Bids, serializer); 
                }
                else if (innerObject["a"] != null)
                {
                    // Only asks
                    innerObject["a"].Populate(obj.Data.Asks, serializer);
                }
                else
                {
                    // Only bids
                    innerObject["b"].Populate(obj.Data.Bids, serializer);
                }

                if (innerObject["c"] != null)
                    obj.Data.Checksum = (uint)innerObject["c"];

                obj.Topic = (string)arr[2];
                obj.Symbol = (string)arr[3];
            }
            else
            {
                arr[1]["a"].Populate(obj.Data.Asks, serializer);
                arr[2]["b"].Populate(obj.Data.Bids, serializer);
                obj.Data.Checksum = (uint)arr[2]["c"];
                obj.Topic = (string)arr[3];
                obj.Symbol = (string)arr[4];
            }
        }

        public static void Populate<T>(this JToken value, T target, JsonSerializer serializer) where T : class
        {
            using (var sr = value.CreateReader())
            {
                serializer.Populate(sr, target); // Uses the system default JsonSerializerSettings
            }
        }

        public static KrakenSocketEvent<KrakenStreamOrderBook> Convert(JArray arr)
        {
            var result = new KrakenSocketEvent<KrakenStreamOrderBook> {ChannelId = (int) arr[0]};

            var orderBook = new KrakenStreamOrderBook();
            if (arr.Count == 4)
            {
                var innerObject = arr[1];
                if (innerObject == null)
                    return null;

                if (innerObject["as"] != null)
                {
                    // snapshot
                    orderBook.Asks = innerObject["as"]!.ToObject<IEnumerable<KrakenStreamOrderBookEntry>>()!;
                    orderBook.Bids = innerObject["bs"]!.ToObject< IEnumerable<KrakenStreamOrderBookEntry>>()!;
                }
                else if (innerObject["a"] != null)
                {
                    // Only asks
                    orderBook.Asks = innerObject["a"]!.ToObject<IEnumerable<KrakenStreamOrderBookEntry>>()!;
                }
                else
                {
                    // Only bids
                    orderBook.Bids = innerObject["b"]!.ToObject<IEnumerable<KrakenStreamOrderBookEntry>>()!;
                }

                if (innerObject["c"] != null)
                    orderBook.Checksum = innerObject["c"]!.Value<uint>();
                
                result.Topic = arr[2].ToString();
                result.Symbol = arr[3].ToString();
            }
            else
            {
                orderBook.Asks = arr[1]["a"]!.ToObject<IEnumerable<KrakenStreamOrderBookEntry>>()!;
                orderBook.Bids = arr[2]["b"]!.ToObject<IEnumerable<KrakenStreamOrderBookEntry>>()!;
                orderBook.Checksum = arr[2]["c"]!.Value<uint>();
                result.Topic = arr[3].ToString();
                result.Symbol = arr[4].ToString();
            }

            result.Data = orderBook;
            return result;
        }
    }
}
