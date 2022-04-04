using Strategy;
using Strategy.Rota;

Frete();

Rota();

void Frete()
{
    PedidoEletronicos pedido = new PedidoEletronicos();
    pedido.Valor = 100;

    //Frete Comun
    IFrete freteComum = new FreteComum();
    pedido.Frete(freteComum);
    Console.WriteLine($"Frete Comun: R$ {pedido.CalcularFrete()}");

    //Frete Expresso
    IFrete freteExpresso = new FreteExpresso();
    pedido.Frete(freteExpresso);
    Console.WriteLine($"Frete Expresso: R$ {pedido.CalcularFrete()}");
}

void Rota()
{
    //Navegacao de Carro
    NavegacaoCarro carro = new NavegacaoCarro();
    carro.Partida = "A";
    carro.Destino = "B";

    IRota rotaCarro = new RotaCarro();
    carro.Rota(rotaCarro);
    Console.WriteLine($"Calculando rota de carro {carro.ContruirRota() }");

    //Navegacao de Carro
    NavegacaoOnibus onibus = new NavegacaoOnibus();
    onibus.Partida = "A";
    onibus.Destino = "B";

    IRota rotaOnibus = new RotaOnibus();
    onibus.Rota(rotaOnibus);
    Console.WriteLine($"Calculando rota de onibus {onibus.ContruirRota() }");
}




