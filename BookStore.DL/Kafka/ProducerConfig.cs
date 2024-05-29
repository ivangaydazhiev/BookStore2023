namespace BookStore.DL.Kafka
{
    internal class ProducerConfig
    {
        public ProducerConfig()
        {
        }

        public string BootstrapServers { get; set; }
        public object SecurityProtocol { get; set; }
        public string SaslUsername { get; set; }
        public string SaslPassword { get; set; }
        public object SaslMechanism { get; set; }
    }
}