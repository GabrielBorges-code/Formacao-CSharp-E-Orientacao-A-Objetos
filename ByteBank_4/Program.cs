using ByteBank_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_2
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                ContaCorrente contaCorrente1 = new ContaCorrente(350, 451);

                contaCorrente1.Depositar(500);
                Console.WriteLine(contaCorrente1.Saldo);
                contaCorrente1.Sacar(700);
                Console.WriteLine(contaCorrente1.Saldo);


            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Argumento com problema: " + ex.ParamName);
                Console.WriteLine("Erro do tipo ArgurmentException");
                //Console.Write(ex.ToString());
            }
            catch(SaldoInsuficienteException ex)
            {
                Console.WriteLine("Exceção do tipo SaldoInsuficienteException");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            
             

            Console.ReadLine();
        }
    }
}
