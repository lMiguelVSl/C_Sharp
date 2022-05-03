using PracticePOOAdvanced;

List<Order> orders = new List<Order>();
orders.Add(new Order() { Id = 1, Amount = 7 });
orders.Add(new Order() { Id = 2, Amount = 5 });
orders.Add(new Order() { Id = 3, Amount = 3 });
orders.Add(new Order() { Id = 4, Amount = 17 });

OrderRepository orderRepository = new OrderRepository(orders);
foreach (var item in orderRepository.FilterOrdersOnAmount(17))
{
    Console.WriteLine($"The order {item.Id} have a cost of {item.Amount}");
}