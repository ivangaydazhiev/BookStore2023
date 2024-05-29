﻿using Confluent.Kafka;
using MessagePack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DL.Kafka
{ 
        public class MessagePackDeserialize<T> : IDeserializer<T>
        {

            public T Deserialize(ReadOnlySpan<byte> data, bool isNull, SerializationContext context)
            {
            return MessagePackSerializer.Deserialize<T>(data.ToArray());
            }    
        }
}
