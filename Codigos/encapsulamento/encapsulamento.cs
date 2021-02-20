//Usando atributos privativos onde não os posso utilizar em outras classes como public.

//Adotar o uso da _ e letra minuscula quando for atributos privados.
pivate string _nome;
private double _preco;
private int _quantidade;

//Implemento manual do uso de get e set

public string GetNome() {
    return _nome;
}

public void SetName(string nome) {
    if (nome != null && nome.Length > 1)
        _nome = nome;
}

public double GetPreco() {
    return _preco;
}