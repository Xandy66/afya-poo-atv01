namespace Ex03_Conta
{
    public class Conta
    {
        private readonly int numeroConta;
        private string titular;
        private double saldo;
        private double limiteChequeEspecial;

        public Conta(int numeroConta, string titular)
        {
            this.numeroConta = numeroConta;
            this.titular = titular;
            this.saldo = 0;
            this.limiteChequeEspecial = 500;
        }

        public int NumeroConta => numeroConta;

        public string Titular
        {
            get => titular;
            set => titular = value;
        }

        public double SaldoTotal => saldo + limiteChequeEspecial;

        public string StatusConta => saldo < 0 ? "Negativo" : "Positivo";

        public string Depositar(double valor)
        {
            if (valor > 0)
            {
                saldo += valor;
                return "Depósito realizado com sucesso";
            }
            return "Valor inválido. Apenas valores positivos são permitidos";
        }

        public string Sacar(double valor)
        {
            if (valor <= 0)
                return "Valor inválido para saque";

            if (valor <= SaldoTotal)
            {
                saldo -= valor;

                if (saldo < 0)
                    return "Saque realizado (usando cheque especial)";

                return "Saque realizado";
            }

            return "Saldo insuficiente";
        }

        public string MostrarSaldo()
        {
            return $"Saldo: {saldo} | Cheque Especial: {limiteChequeEspecial} | Saldo Total: {SaldoTotal}";
        }

        public override string ToString()
        {
            return $"Conta: {NumeroConta} | Titular: {Titular} | Saldo: {saldo} | Limite: {limiteChequeEspecial} | Status: {StatusConta}";
        }
    }
}