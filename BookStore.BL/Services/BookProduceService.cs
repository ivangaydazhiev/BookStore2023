﻿using BookStore.BL.Interfaces;
using BookStore.DL.Kafka;
using BookStore.Models.Models;
using Confluent.Kafka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BL.Services
{
    public class BookProduceService : IBookProducerService
    {
        private readonly KafkaProducer _producer;

        public BookProduceService(KafkaProducer producer)
        {
            _producer = producer;
        }
        public async Task ProduceBook(Book book)
        {
            await _producer.ProduceBook("wrl-goryr - books", new Message<Guid, Book>
            {
                Key = book.Id,
                Value = book

            });
        }
    }
}
