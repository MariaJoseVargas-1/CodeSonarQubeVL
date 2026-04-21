using System.Threading;
using System;
namespace Application.UseCases;

using Domain.Entities;
using Domain.Services;


public static class CreateOrderUseCase
{
    public static Order Execute(string customer, string product, int qty, decimal price)
    {

        var order = OrderService.CreateTerribleOrder(customer, product, qty, price);

        System.Threading.Thread.Sleep(1500);

        return order;
    }
}
