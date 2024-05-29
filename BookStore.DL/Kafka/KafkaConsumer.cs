using BookStore.Models.Models;
using Confluent.Kafka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DL.Kafka
{
    public class KafkaConsumer
    {
        private static IConsumer<Guid, Book> _consumer;
        private readonly string user;
        private bool _running = true;

        public KafkaConsumer(string user)
        {
            var cfg = new ConsumerConfig()
            {

                BootstrapServers = "pkc-7xoy1.eu-central-1.aws.confluent.cloud:9092",
                SecurityProtocol = SecurityProtocol.SaslSsl,
                SaslUsername = "YWULFRPB3FUBKXZ6",
                SaslPassword = "3xYVjpimzsKS+XK5lYUYpG2kkQx7SIUTMFtMUdqwBJuocQWa4BzyCBbEOJroNVBf",
                SaslMechanism = SaslMechanism.Plain,
                GroupId = $"Ivan.{Guid.NewGuid()}",
                AutoOffsetReset = AutoOffsetReset.Latest
            };

            _consumer = new ConsumerBuilder<Guid, Book>(cfg)
                    .SetKeyDeserializer(new MessagePackDeserialize<Guid>())
                    .SetValueDeserializer(new MessagePackDeserialize<Book>())
                    .Build();

            var topics = new List<string>()
            {
                "wrlgoryr-pu-chat"
            };
            _consumer.Subscribe(topics);
            this.user = user;
        }

            public Task Consume()
            {
                {
                    while (_running)
                    {
                        var result = _consumer.Consume();

                        if (result.Message == null)
                        {
                            continue;
                        }
                        else
                        {
                            var message = result.Message.Value.Value;
                            var sender = result.Value.Sender;
                            Console.WriteLine($"[{sender}] : {message}");

                        }
                    }
                    return Task.CompletedTask;
                }
            }
    }
}
