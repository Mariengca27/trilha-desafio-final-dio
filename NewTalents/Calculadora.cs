using System;
using System.Collections.Generic;
using System.Text;

namespace NewTalents
{
	public class Calculadora
	{
		private List<string> listahistorico;
		private string data;
		public Calculadora(string data) {

			listahistorico = new List<string>();
			this.data = data;
		}

		public int Soma(int a, int b)
		{
			int somaResult = a + b;
			listahistorico.Insert(0, "RESULTADO" + somaResult + "DATA:"+ data );

			return somaResult;
		}

		public int Subtracao(int a, int b)
		{
			int subResult = a - b;
			listahistorico.Insert(0, "RESULTADO" + subResult + "DATA:" + data);
			return subResult;

		}

		public int Multiplicacao(int a, int b)
		{
			int multResult = a * b;
			listahistorico.Insert(0, "RESULTADO" + multResult + "DATA:" + data);
			return multResult;

		}

		public int Divisao(int a, int b)
		{
			if (b == 0)
			{
				throw new DivideByZeroException();
			}
			int divResult = a / b;
			listahistorico.Insert(0, "RESULTADO" + divResult + "DATA:" + data);
			return divResult;

		}
		public List<string> Historico()
		{
			
			listahistorico.RemoveRange(3, listahistorico.Count-3);
			return listahistorico;

		}

	}
}
