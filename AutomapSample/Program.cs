// See https://aka.ms/new-console-template for more information
using AutoMapper;
using AutomapSample.Objects;

Console.WriteLine("Hello, World!");

var config = 
    new MapperConfiguration(
        cfg => cfg.CreateMap<Order, OrderDto>());

var mapper = config.CreateMapper();
Order order = new Order() 
{ 
    Name = "test", OrderDate = DateTime.Now, AmountPrice = 100
};
OrderDto orderDto = mapper.Map<OrderDto>(order);

Console.WriteLine("order: name = {0}, date = {1}, price = {2}", order.Name, order.OrderDate, order.AmountPrice);
Console.WriteLine("order(dto): name = {0}, date = {1}, price = {2}", orderDto.Name, orderDto.OrderDate, orderDto.Amount);