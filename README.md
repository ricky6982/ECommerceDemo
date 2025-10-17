ECommerceDemo
=============

This small project aims to practice MassTransit and RabbitMQ to desacouple the flow of some operations.
At this stage, it has two main service OrderService and BillingService which interact througha message queue. 
Currently, the project doesn't have a configured persistence layer, as the interactions are performed with mocks entities. 
