using Ch5.DomainIF.Objects;
using System.Collections.Generic;
using System.IO;

namespace Ch5.DomainConcrete.Objects
{
    public class StreamTradeDataProvider : ITradeDataProvider
    {
        private readonly Stream _stream;
        public StreamTradeDataProvider(Stream stream)
        {
            _stream = stream;
        }
        public IEnumerable<string> GetTradeData()
        {
            var lines = new List<string>();
            using (var reader = new StreamReader(_stream))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }
            return lines;
        }
    }
}
