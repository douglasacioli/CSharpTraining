LerArquivo(1);

void LerArquivo(int numeroArquivo)
{

    string caminho =@"C:\Users\Dell\OneDrive\Área de Trabalho\21csharp\21CSharp\teste" + (numeroArquivo) + ".txt";
    if (File.Exists(caminho))
    {
        using (StreamReader arq = File.OpenText(caminho))
        {
            string linha;
            while ((linha = arq.ReadLine()) != null)
            {
                System.Console.WriteLine(linha);
            }
        }
    }

    string caminho2 = @"C:\Users\Dell\OneDrive\Área de Trabalho\21csharp\21CSharp\teste" + (numeroArquivo + 1) + ".txt";
    if (File.Exists(caminho2))
    {
        LerArquivo(numeroArquivo + 1);
    }

}