class Program
{
    static void Main()
    {
        //Valor total a ser comparado
        Console.WriteLine("Digite o valor principal: ");
        string input1 = Console.ReadLine();

        //Valor percentual total
        Console.WriteLine($"Digite o valor % equivalente de {input1}: ");
        string input2 = Console.ReadLine(); 

        //Valor desejado do percentual total
        Console.WriteLine("Digite o valor de comparação % ");
        string input3 = Console.ReadLine();

        //Conversão dos inputs informados pelo usuario para decimais
        double numero1 = double.Parse(input1);
        double numero2 = double.Parse(input2);
        double numero3 = double.Parse(input3);

        //Conculo da regra de 3 simples
        double soma = (numero2 * numero3) / numero1;

        //Formatação de casas decimais
        int casasDecimais = 2;
        String formato = "N" + casasDecimais.ToString();
        string valorFormatado = string.Format("{0:" + formato + "}", soma);

        //Exibição dos valores equivalentes e percentuais
        Console.WriteLine($"Então {numero3} é {valorFormatado}% de {numero1}");
    }
}