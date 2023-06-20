using Atividade_1.Classes;


Console.WriteLine("Cadastro de Clientes");
Console.Write("Por favor, digite o nome: ");
string nome = Console.ReadLine();
Console.Write("Digite o seu endereço: ");
string endereco = Console.ReadLine();
Console.Write("Informe o valor a pagar: ");
double valorPag;
double.TryParse(Console.ReadLine(), out valorPag);
Console.WriteLine("Digite F para pessoa física e J para jurídica");
char tipo = Convert.ToChar(Console.ReadLine());
if (tipo == 'F' || tipo == 'f')
{
    PessoaFisica pf = new PessoaFisica();
    Console.Write("Por favor, digite o seu CPF: ");
    string cpf = Console.ReadLine();
    Console.Write("Digite o seu RG: ");
    string rg = Console.ReadLine();
    pf.Nome = nome;
    pf.Endereco = endereco;
    pf.Cpf = cpf;
    pf.Rg = rg;
   
    pf.PagarImposto(valorPag);
    Console.WriteLine("-------------------------------------------------");

    Console.WriteLine($"Cliente: {pf.Nome}\nEndereço{pf.Endereco}\nCNPJ: {pf.Cpf}\nIE: {pf.Rg}\nValor: R${pf.Valor.ToString("F2")}\nValor do Imposto: R${pf.ValorImposto.ToString("F2")}\nTotal: R${pf.Total.ToString("F2")}");
}
else if(tipo == 'J'|| tipo == 'j')
{

    PessoaJuridica pj = new PessoaJuridica();
    Console.Write("Por favor, digite o seu CNPJ: ");
    string cnpj = Console.ReadLine();
    Console.Write("Digite o seu IE: ");
    string ie = Console.ReadLine();
    pj.Nome = nome;
    pj.Endereco = endereco;
    pj.Cnpj = cnpj;
    pj.Ie = ie;

    pj.PagarImposto(valorPag);
    Console.WriteLine("--------------------------------------------------");
    Console.WriteLine($"Cliente: {pj.Nome}\nEndereço{ pj.Endereco}\nCNPJ: {pj.Cnpj}\nIE: {pj.Ie}\nValor: R${pj.Valor.ToString("F2")}\nValor do Imposto: R${pj.ValorImposto.ToString("F2")}\nTotal: R${pj.Total.ToString("F2")}");

}
else
{
    Console.WriteLine("Valor inválido.");
}
