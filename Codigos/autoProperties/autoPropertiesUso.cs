private string _nome;
public double Preco { get; private set; }
public int Quantidade { get; private set; }

//A palavra value nesse caso é usada como o parametro nome que o metodo recebe para mudança
//E no atributo Nome como há essa lógica a implementação continua a mesma.
//
public string Name {
    get {return _name}
    set {
        if (value != null && value.Length > 1)
        _nome = value;
    }
}