﻿using Newtonsoft.Json;
using RabbitMQ.Client;
using System;
using System.Text;

namespace RabbitMQ.Producer
{
    static class Program
    {
        static void Main(string[] args)
        {
            var factory = new ConnectionFactory
            {
                Uri = new Uri("amqp://guest:guest@localhost:5672")
            };

            using var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();
            FenaoutExchangePublisher.Publish(channel);
            //HeaderExchangePublisher.Publish(channel);
            //TopicExchangePublisher.Publish(channel);
            //DirectyExchangePublisher.Publish(channel);
            //QueueProducer.Publish(channel);
        }
    }
}
