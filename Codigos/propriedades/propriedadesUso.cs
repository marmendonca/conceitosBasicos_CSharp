pivate string _nome;
private double _preco;
private int _quantidade;

//A palavra value nesse caso é usada como o parametro nome que o metodo recebe para mudança
public string Name {
    get {return _name}
    set {
        if (value != null && value.Length > 1)
        _nome = value;
    }
}

public double Preco {
    get {return _preco}
}

public int Quantidade {
    get {return _quantidade}
}

//Nos atributos Preco e Quantidade só são modificados com a chamada dos métodos de Adicionar e Remover produtos.