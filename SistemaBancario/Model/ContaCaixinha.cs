using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Model
{
    public class ContaCaixinha : Conta
    {
        public ContaCaixinha(decimal saldoInicial) : base(saldoInicial) { }

        public override void Depositar(decimal valor)
        {
            if (valor <= 1)
                throw new ArgumentOutOfRangeException("O valor do deposito deve ser maior que  ");
            base.Depositar(valor + 1);
        }
        public override void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentOutOfRangeException("O valor do saque deve ser maior que zero.");
            }
            valor += 5;
            base.Sacar(valor);
        }
    }
}