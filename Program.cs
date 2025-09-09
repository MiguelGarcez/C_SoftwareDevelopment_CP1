namespace CheckPoint1;

internal static class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== CHECKPOINT 1 - FUNDAMENTOS C# - Turma  3ESPY ===\n");
        
        //********************************************************//
        //      3ESPR - MIGUEL GARCEZ DE CARVALHO - 553768        //
        //********************************************************//

        // ENTREGA ATÉ DIA 08/09 AS 23:59
        // Você deve criar um repositório público ou branch no github e me enviar o link pelo
        // teams antes do fim do prazo.
        // IMPORTANTE:
        // - Não haverá reposição do checkpoint.
        // - Fique atento ao prazo, nenhum trabalho será aceito após a data e vou me basear
        // - O link do seu git deve ser enviado no teams. A data e hora do recebimento do git será utilizada para verificar se foi enviado no prazo.
        // 
        
        // TODO: Implemente as chamadas de teste para demonstrar funcionamento
        // NÃO é obrigatório testar todos os caminhos/casos - apenas mostrar que funciona
        // Use valores de teste simples para validar cada implementação

        //  Treinem rodar o debugger.
        //  F9 - Coloca o breakpoint
        //  F10 - Passa sobre o método no passo a passo
        //  F11 - Entra nos métodos no passo a passo
        //  shift  + F11 - Volta do método

        
        
        Console.WriteLine("1. Testando DemonstrarTiposDados...");
        Console.WriteLine(DemonstrarTiposDados());

        Console.WriteLine("\n2. Testando CalculadoraBasica (SWITCH)...");
        Console.WriteLine(CalculadoraBasica(10, 5, '+'));

        Console.WriteLine("\n3. Testando ValidarIdade (IF/ELSE)...");
        Console.WriteLine(ValidarIdade(25));

        Console.WriteLine("\n4. Testando ConverterString...");
        Console.WriteLine(ConverterString("123", "int"));

        Console.WriteLine("\n5. Testando ClassificarNota (SWITCH)...");
        Console.WriteLine(ClassificarNota(8.5));

        Console.WriteLine("\n6. Testando GerarTabuada (FOR)...");
        Console.WriteLine(GerarTabuada(5));

        Console.WriteLine("\n7. Testando JogoAdivinhacao (WHILE)...");
        Console.WriteLine(JogoAdivinhacao(50, new int[]{25, 75, 50}));

        Console.WriteLine("\n8. Testando ValidarSenha (DO-WHILE)...");
        Console.WriteLine(ValidarSenha("MinhaSenh@123"));

        Console.WriteLine("\n9. Testando AnalisarNotas (FOREACH)...");
        Console.WriteLine(AnalisarNotas(new double[]{8.5, 7.0, 9.2, 6.5, 10.0}));

        Console.WriteLine("\n10. Testando ProcessarVendas (FOREACH múltiplo)...");
        Console.WriteLine(ProcessarVendas(new double[]{1000, 500, 800}, new string[]{"A", "B", "A"}, new double[]{10, 7, 5}, new string[]{"A", "B", "C"}));

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }

    // =====================================================================
    // QUESTÃO 1 - VARIÁVEIS E TIPOS DE DADOS (10 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: Complete o método para demonstrar diferentes tipos de dados
    /// - Declare uma variável de cada tipo primitivo (int, double, bool, char, string)
    /// - Use inferência de tipos (var) onde apropriado
    /// - Retorne uma string concatenando todos os valores
    /// </summary>
    private static string DemonstrarTiposDados()
    {
        // TODO: Implementar
        // Exemplo de retorno: "Inteiro: 42, Decimal: 3.14, Booleano: True, Caractere: A, Texto: Olá"
        int inteiro = 42;
        double numeroDecimal = 3.14;
        bool booleano = true;
        char caractere = 'A';
        string texto = "Olá";
        var inferido = 100;

        // throw new NotImplementedException("Implementar DemonstrarTiposDados");
        return $"Inteiro: {inteiro}, Decimal: {numeroDecimal}, Booleano: {booleano}, Caractere: {caractere}, Texto: {texto}, Inferido: {inferido}";
    }

    // =====================================================================
    // QUESTÃO 2 - OPERADORES ARITMÉTICOS (10 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: Implemente uma calculadora básica usando SWITCH
    /// - Receba dois números e um operador (+, -, *, /)
    /// - Use SWITCH para selecionar a operação
    /// - Trate divisão por zero retornando 0
    /// - Para operadores inválidos, retorne -1
    /// </summary>
    private static double CalculadoraBasica(double num1, double num2, char operador)
    {
        // TODO: Implementar OBRIGATORIAMENTE usando SWITCH
        // Exemplo de estrutura:
        // switch (operador)
        // {
        //     case '+': return num1 + num2;
        //     case '-': return num1 - num2;
        //     // etc...
        // }

        // throw new NotImplementedException("Implementar CalculadoraBasica com SWITCH");
        switch (operador)
        {
            case '+': return num1 + num2;
            case '-': return num1 - num2;
            case '*': return num1 * num2;
            case '/': return num2 == 0 ? 0 : num1 / num2;
            default: return -1;
        }
    }

    // =====================================================================
    // QUESTÃO 3 - OPERADORES RELACIONAIS E LÓGICOS (10 pontos)  
    // =====================================================================

    /// <summary>
    /// TODO: Valide se uma idade é válida para diferentes contextos usando IF/ELSE
    /// - Use IF/ELSE encadeados (não switch)
    /// - Retorna "Criança" se idade < 12
    /// - Retorna "Adolescente" se idade >= 12 e < 18  
    /// - Retorna "Adulto" se idade >= 18 e <= 65
    /// - Retorna "Idoso" se idade > 65
    /// - Retorna "Idade inválida" se idade < 0 ou > 120
    /// Use operadores relacionais e lógicos
    /// </summary>
    private static string ValidarIdade(int idade)
    {
        // TODO: Implementar OBRIGATORIAMENTE usando IF/ELSE (não switch)
        // Exemplo de estrutura:
        // if (idade < 0 || idade > 120)
        //     return "Idade inválida";
        // else if (idade < 12)
        //     return "Criança";
        // Continue com else if...

        // throw new NotImplementedException("Implementar ValidarIdade com IF/ELSE");
        if (idade < 0 || idade > 120)
            return "Idade inválida";
        else if (idade < 12)
            return "Criança";
        else if (idade >= 12 && idade < 18)
            return "Adolescente";
        else if (idade >= 18 && idade <= 65)
            return "Adulto";
        else
            return "Idoso";
    }

    // =====================================================================
    // QUESTÃO 4 - CONVERSÃO DE TIPOS (10 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: Converta uma string para diferentes tipos
    /// - Tente converter 'valor' para int, double e bool
    /// - Se a conversão for bem-sucedida, retorne "Tipo: Valor convertido"
    /// - Se falhar, retorne "Conversão impossível para [tipo]"
    /// - Use TryParse para conversões seguras
    /// </summary>
    private static string ConverterString(string valor, string tipoDesejado)
    {
        // TODO: Implementar conversões usando TryParse
        // tipoDesejado pode ser: "int", "double", "bool"

        // throw new NotImplementedException("Implementar ConverterString");
        switch (tipoDesejado.ToLower())
        {
            case "int":
                if (int.TryParse(valor, out int resultInt))
                    return $"int: {resultInt}";
                else
                    return "Conversão impossível para int";

            case "double":
                if (double.TryParse(valor, out double resultDouble))
                    return $"double: {resultDouble}";
                else
                    return "Conversão impossível para double";

            case "bool":
                if (bool.TryParse(valor, out bool resultBool))
                    return $"bool: {resultBool}";
                else
                    return "Conversão impossível para bool";

            default:
                return $"Tipo {tipoDesejado} não suportado";
        }
    }

    // =====================================================================
    // QUESTÃO 5 - ESTRUTURA CONDICIONAL SWITCH (10 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: Classifique uma nota usando switch expression (C# 8+) ou switch tradicional
    /// - 9.0 a 10.0: "Excelente"
    /// - 7.0 a 8.9: "Bom" 
    /// - 5.0 a 6.9: "Regular"
    /// - 0.0 a 4.9: "Insuficiente"
    /// - Fora da faixa: "Nota inválida"
    /// </summary>
    private static string ClassificarNota(double nota)
    {
        // TODO: Implementar usando switch (pode usar switch expression se conhecer)

        // throw new NotImplementedException("Implementar ClassificarNota");
        return nota switch
        {
            >= 9.0 and <= 10.0 => "Excelente",
            >= 7.0 and < 9.0 => "Bom",
            >= 5.0 and < 7.0 => "Regular",
            >= 0.0 and < 5.0 => "Insuficiente",
            _ => "Nota inválida"
        };
    }

    // =====================================================================
    // QUESTÃO 6 - ESTRUTURA FOR (10 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: OBRIGATÓRIO USAR FOR
    /// Gere a tabuada de um número de 1 a 10
    /// - Use FOR para iterar de 1 a 10
    /// - Retorne string formatada: "2 x 1 = 2\n2 x 2 = 4\n..." 
    /// - Se número for <= 0, retorne "Número inválido"
    /// </summary>
    private static string GerarTabuada(int numero)
    {
        // TODO: Implementar OBRIGATORIAMENTE com FOR

        // throw new NotImplementedException("Implementar GerarTabuada com FOR");
        if (numero <= 0)
            return "Número inválido";

        string resultado = "";
        for (int i = 1; i <= 10; i++)
        {
            resultado += $"{numero} x {i} = {numero * i}";
            if (i < 10)
                resultado += "\n";
        }
        return resultado;
    }

    // =====================================================================
    // QUESTÃO 7 - ESTRUTURA WHILE (15 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: OBRIGATÓRIO USAR WHILE
    /// Simule um jogo de adivinhar número com tentativas limitadas
    /// - numeroSecreto: número a ser adivinhado (1-100)
    /// - tentativas: array com os palpites do jogador
    /// - Use WHILE para percorrer as tentativas
    /// - Para cada tentativa: "Tentativa X: muito alto/baixo/correto"
    /// - Pare no acerto ou quando acabar as tentativas
    /// - Retorne string com histórico completo
    /// </summary>
    private static string JogoAdivinhacao(int numeroSecreto, int[] tentativas)
    {
        // TODO: Implementar OBRIGATORIAMENTE com WHILE
        // Exemplo: "Tentativa 1: 50 - muito baixo\nTentativa 2: 75 - muito alto\nTentativa 3: 63 - correto!"

        // throw new NotImplementedException("Implementar JogoAdivinhacao com WHILE");
        string resultado = "";
        int i = 0;
        
        while (i < tentativas.Length)
        {
            int tentativa = tentativas[i];
            string status;
            
            if (tentativa == numeroSecreto)
                status = "correto!";
            else if (tentativa < numeroSecreto)
                status = "muito baixo";
            else
                status = "muito alto";
            
            resultado += $"Tentativa {i + 1}: {tentativa} - {status}";
            
            if (tentativa == numeroSecreto)
                break;
                
            if (i < tentativas.Length - 1)
                resultado += "\n";
                
            i++;
        }
        
        return resultado;
    }

    // =====================================================================
    // QUESTÃO 8 - ESTRUTURA DO-WHILE (15 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: OBRIGATÓRIO USAR DO-WHILE
    /// Valide uma senha seguindo critérios de segurança
    /// - A senha deve ter pelo menos 8 caracteres
    /// - Deve ter pelo menos 1 número
    /// - Deve ter pelo menos 1 letra maiúscula  
    /// - Deve ter pelo menos 1 caractere especial (!@#$%&*)
    /// - Use DO-WHILE para verificar cada critério
    /// - Retorne string explicando quais critérios não foram atendidos
    /// - Se senha válida, retorne "Senha válida"
    /// </summary>
    private static string ValidarSenha(string senha)
    {
        // TODO: Implementar OBRIGATORIAMENTE com DO-WHILE
        // Use do-while para verificar cada critério da senha

        // throw new NotImplementedException("Implementar ValidarSenha com DO-WHILE");
        
        if (string.IsNullOrEmpty(senha))
            return "Senha não pode ser nula ou vazia";

        var criterios = new List<string>();
        var caracteresEspeciais = "!@#$%&*";
        
        // Verificar comprimento
        if (senha.Length < 8)
            criterios.Add("pelo menos 8 caracteres");

        // Verificar critérios usando do-while
        int i = 0;
        bool temNumero = false;
        bool temMaiuscula = false;
        bool temEspecial = false;
        
        do
        {
            char c = senha[i];
            
            if (char.IsDigit(c))
                temNumero = true;
            else if (char.IsUpper(c))
                temMaiuscula = true;
            else if (caracteresEspeciais.Contains(c))
                temEspecial = true;
                
            i++;
        }
        while (i < senha.Length);
        
        if (!temNumero)
            criterios.Add("pelo menos 1 número");
        if (!temMaiuscula)
            criterios.Add("pelo menos 1 letra maiúscula");
        if (!temEspecial)
            criterios.Add("pelo menos 1 caractere especial (!@#$%&*)");
            
        if (criterios.Count == 0)
            return "Senha válida";
        else
            return $"Senha deve ter: {string.Join(", ", criterios)}";
    }

    // =====================================================================
    // QUESTÃO 9 - ESTRUTURA FOREACH (15 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: OBRIGATÓRIO USAR FOREACH
    /// Analise um array de notas de alunos
    /// - Use FOREACH para percorrer todas as notas
    /// - Calcule: média, quantidade de aprovados (>=7), maior nota, menor nota
    /// - Conte quantas notas estão em cada faixa: A(9-10), B(8-8.9), C(7-7.9), D(5-6.9), F(<5)
    /// - Retorne string formatada com todas as estatísticas
    /// - Se array vazio/null: "Nenhuma nota para analisar"
    /// </summary>
    private static string AnalisarNotas(double[] notas)
    {
        // TODO: Implementar OBRIGATORIAMENTE com FOREACH
        // Retorno exemplo: "Média: 7.5\nAprovados: 15\nMaior: 9.8\nMenor: 3.2\nA: 3, B: 4, C: 8, D: 2, F: 1"

        // throw new NotImplementedException("Implementar AnalisarNotas com FOREACH");
        
        if (notas == null || notas.Length == 0)
            return "Nenhuma nota para analisar";
            
        double soma = 0;
        int aprovados = 0;
        double maior = notas[0];
        double menor = notas[0];
        int contA = 0, contB = 0, contC = 0, contD = 0, contF = 0;
        
        foreach (double nota in notas)
        {
            soma += nota;
            
            if (nota >= 7.0)
                aprovados++;
                
            if (nota > maior)
                maior = nota;
            if (nota < menor)
                menor = nota;
                
            // Classificar por faixa
            if (nota >= 9.0 && nota <= 10.0)
                contA++;
            else if (nota >= 8.0 && nota < 9.0)
                contB++;
            else if (nota >= 7.0 && nota < 8.0)
                contC++;
            else if (nota >= 5.0 && nota < 7.0)
                contD++;
            else if (nota >= 0.0 && nota < 5.0)
                contF++;
        }
        
        double media = soma / notas.Length;
        
        return $"Média: {media:F1}\nAprovados: {aprovados}\nMaior: {maior:F1}\nMenor: {menor:F1}\nA: {contA}, B: {contB}, C: {contC}, D: {contD}, F: {contF}";
    }

    // =====================================================================
    // QUESTÃO 10 - MULTIPLE FOREACH (DESAFIO) (20 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: OBRIGATÓRIO USAR FOREACH (múltiplos)
    /// Processe vendas por categoria e calcule comissões
    /// - vendas: array com valores de vendas
    /// - categorias: array com categorias correspondentes ("A", "B", "C")
    /// - comissoes: array com percentuais de comissão por categoria (ex: A=10%, B=7%, C=5%)
    /// - Use FOREACH para percorrer vendas e categorias simultaneamente
    /// - Use FOREACH separado para encontrar a comissão da categoria
    /// - Calcule total de vendas e total de comissões por categoria
    /// - Retorne string com relatório detalhado
    /// </summary>
    private static string ProcessarVendas(double[] vendas, string[] categorias, double[] comissoes, string[] nomesCategorias)
    {
        // TODO: Implementar com múltiplos FOREACH
        // Exemplo: "Categoria A: Vendas R$ 1500,00, Comissão R$ 150,00\nCategoria B: Vendas R$ 800,00, Comissão R$ 56,00"

        // throw new NotImplementedException("Implementar ProcessarVendas com FOREACH");
        
        if (vendas == null || categorias == null || comissoes == null || nomesCategorias == null)
            return "Arrays não podem ser nulos";
            
        if (vendas.Length != categorias.Length)
            return "Arrays de vendas e categorias devem ter o mesmo tamanho";
            
        var totaisVendas = new Dictionary<string, double>();
        var totaisComissoes = new Dictionary<string, double>();
        
        // Inicializar totais
        foreach (string categoria in nomesCategorias)
        {
            totaisVendas[categoria] = 0;
            totaisComissoes[categoria] = 0;
        }
        
        // Processar vendas usando FOREACH
        int index = 0;
        foreach (double venda in vendas)
        {
            string categoria = categorias[index];
            
            // Encontrar comissão da categoria usando FOREACH
            double percentualComissao = 0;
            int comissaoIndex = 0;
            foreach (string nomeCategoria in nomesCategorias)
            {
                if (nomeCategoria == categoria)
                {
                    percentualComissao = comissoes[comissaoIndex];
                    break;
                }
                comissaoIndex++;
            }
            
            double valorComissao = venda * (percentualComissao / 100);
            
            if (totaisVendas.ContainsKey(categoria))
            {
                totaisVendas[categoria] += venda;
                totaisComissoes[categoria] += valorComissao;
            }
            
            index++;
        }
        
        // Gerar relatório
        var resultado = new List<string>();
        foreach (string categoria in nomesCategorias)
        {
            if (totaisVendas[categoria] > 0)
            {
                resultado.Add($"Categoria {categoria}: Vendas R$ {totaisVendas[categoria]:F2}, Comissão R$ {totaisComissoes[categoria]:F2}");
            }
        }
        
        return string.Join("\n", resultado);
    }

    // =====================================================================
    // MÉTODOS AUXILIARES (NÃO ALTERAR - APENAS PARA REFERÊNCIA)
    // =====================================================================

    /// <summary>
    /// Método de exemplo demonstrando diferença entre estático e de instância
    /// ESTÁTICO: Pertence à classe, não precisa criar objeto para usar
    /// </summary>
    private static void ExemploMetodoEstatico()
    {
        Console.WriteLine("Sou um método estático - chamado direto da classe");
    }

    /// <summary>
    /// Método de exemplo de instância (comentado pois não pode ser chamado do Main estático)
    /// DE INSTÂNCIA: Pertence ao objeto, precisa criar instância da classe
    /// </summary>
    /*
    void ExemploMetodoInstancia()
    {
        Console.WriteLine("Sou um método de instância - preciso de um objeto para ser chamado");
    }
    */
}