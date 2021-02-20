namespace parametros
{
    class Calculator
    {
        //foi criado uma função estatica para somar valores passados a ela
        //                      o params me permite não instanciar o objeto quando passar um valor a ele na chamada do metodo
        public static int Sum (params int[] numbers)
        {
            int sum = 0;
            //aqui eu verifico o tamanho do vetor e faço a interação
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
