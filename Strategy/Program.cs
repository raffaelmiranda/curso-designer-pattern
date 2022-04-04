using Strategy;

PedidoEletronicos pedido = new PedidoEletronicos();
pedido.Valor(100);

//Frete Comun
IFrete freteComum = new FreteComum();
pedido.Frete(freteComum);
Console.WriteLine($"Frete Comun: R$ {pedido.CalcularFrete()}");

//Frete Expresso
IFrete freteExpresso = new FreteExpresso();
pedido.Frete(freteExpresso);
Console.WriteLine($"Frete Expresso: R$ {pedido.CalcularFrete()}");


