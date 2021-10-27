using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Address : ValueObject
    {
        public Address(string rua, string numero, string complemento, string bairro, string cEP, string cidade, string estado, string pais)
        {
            Rua = rua;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            CEP = cEP;
            Cidade = cidade;
            Estado = estado;
            Pais = pais;

            ////TODO: Implementar para Fluent Validator
        }

        public string Rua { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string CEP { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public string Pais { get; private set; }
    }
}