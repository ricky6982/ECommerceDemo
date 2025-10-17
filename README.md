ECommerceDemo
=============

Overview
--------

This small project was created to practice using MassTransit and RabbitMQ in order to decouple communication between microservices.
The main goal is to simulate a simple event-driven architecture, focusing on message-based integration rather than direct service dependencies.

Architecture
------------

At this stage, the solution contains two main services:

 - OrderService – responsible for creating and publishing order-related events.

 - BillingService – subscribes to those events and performs billing-related actions.

These services interact through a message queue using RabbitMQ as the transport and MassTransit as the abstraction layer.

```
OrderService  →  [MassTransit + RabbitMQ]  →  BillingService
```

Persistence Layer
-----------------

Currently, the project does not include a persistence layer, since all interactions are handled through mock entities.
This allows focusing exclusively on the messaging flow and service communication.

Technologies
------------

 - .NET 8
 - MassTransit
 - RabbitMQ
 - C# 12

Future Improvements
-------------------

1. Add a proper persistence layer (Entity Framework Core + SQL Server).
1. Implement additional services to extend the event-driven flow.
1. Add integration tests for message publishing and consuming.

Purpose
-------

This project is intended for educational and experimental purposes, helping to understand how to implement message-based communication between distributed services using MassTransit and RabbitMQ.