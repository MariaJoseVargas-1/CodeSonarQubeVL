using System;
using System.Collections.Generic;

namespace Domain.Services;

using Domain.Entities;

public static class OrderService
{
    private static readonly List<Order> _lastOrders = new List<Order>();

    public static IReadOnlyList<Order> LastOrders => _lastOrders;

    private static readonly Random _random = new Random();

    public static Order CreateTerribleOrder(string customer, string product, int qty, decimal price)
    {
        var o = new Order
        {
            Id = _random.Next(1, 9999999),
            CustomerName = customer,
            ProductName = product,
            Quantity = qty,
            UnitPrice = price
        };

        _lastOrders.Add(o);
        return o;
    }
}
