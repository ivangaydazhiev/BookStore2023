using BookStore.Models.Models;
using Confluent.Kafka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DL.Kafka
{
    public class KafkaProducer
    {

        private static IProducer<Guid, Book> _producer;
        private readonly string _user;

        public KafkaProducer(string user)
        {

            var config = new ProducerConfig()
            {
                BootstrapServers = "sulky.srvs.cloudkafka.com:9094",
                SecurityProtocol = SecurityProtocol.SaslSsl,
                SaslUsername = "wrlgoryr",
                SaslPassword = "cfcSFJUaHz7tVE-wButfZIb51GTR-3lx",
                SaslMechanism = SaslMechanism.ScramSha512
            };

            _producer = new ProducerBuilder<Guid, Book>((IEnumerable<KeyValuePair<string, string>>)config)
                .SetKeySerializer(new MessagePackSerialization<Guid>())
                .SetValueSerializer(new MessagePackSerialization<Book>())
                    .Build();
       
        }
        public async Task ProduceBook(string topic, Message<Guid, Book> msg)
        {
            await _producer.ProduceAsync(topic, msg);
        }
    }
}


