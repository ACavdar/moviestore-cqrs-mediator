# Movie Store 

A simple project to demonstrate CQRS and Mediator Behavioral Design Pattern. In this project I will be folloing the guidelines of Jason Taylor's Clean Architecture solution template (https://github.com/jasontaylordev/CleanArchitecture).

## Technologies 

* [ASP.NET Core 6](https://docs.microsoft.com/en-us/aspnet/core/introduction-to-aspnet-core?view=aspnetcore-6.0)
* [Entity Framework Core 6](https://docs.microsoft.com/en-us/ef/core/)
* [MediatR](https://github.com/jbogard/MediatR)
* [AutoMapper](https://automapper.org/)
* [FluentValidation](https://fluentvalidation.net/)

## Project Structure Overview

Project structure from inner-most module to outer-most module will be as follows: 

* MovieStore.Domain
* MovieStore.Application
* MovieStore.Infrastructure
* MovieStore.API
