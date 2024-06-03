using System;
using Xunit;
using NewTalents;

namespace TestesNewTalents
{
	public class UnitTest1
	{

		public Calculadora ConstruirClasse()
		{
			string data = "2021-09-01";
		    Calculadora calculadora = new Calculadora(data);
			return calculadora;
		}



		[Theory]
		[InlineData(1, 2, 3)]
		[InlineData(2, 3, 5)]
		public void TestSomar(int val1, int val2, int resul)
		{
			Calculadora calc = ConstruirClasse();
			int resultadoCalculadora = calc.Soma(val1, val2);
			Assert.Equal(resul , resultadoCalculadora);
		}

		[Theory]
		[InlineData(3, 2, 1)]
		[InlineData(4, 3, 1)]
		public void TestSubtracao(int val1, int val2, int resul)
		{
			Calculadora calc = ConstruirClasse();
			int resultado = calc.Subtracao(val1, val2);
			Assert.Equal(resul, resultado);
		}

		[Theory]
		[InlineData(1, 2, 2)]
		[InlineData(2, 3, 6)]
		public void TestMultiplicacao(int val1, int val2, int resul)
		{
			Calculadora calc = ConstruirClasse();
			int resultado = calc.Multiplicacao(val1, val2);
			Assert.Equal(resul, resultado);
		}

		[Fact]
		public void TestDivisaoPorZero()
		{
			Calculadora calc = ConstruirClasse();

			Assert.Throws<DivideByZeroException>(() =>	
			{
				calc.Divisao(3, 0);
			});
			
		}

		[Theory]

		[InlineData(2, 1, 2)]
		[InlineData(6, 3, 2)]
		public void TestDivisao(int val1, int val2, int resul)
		{
			Calculadora calc = ConstruirClasse();
			int resultado = calc.Divisao(val1, val2);
			Assert.Equal(resul, resultado);
		}



		[Fact]
		public void TestHistorico()
		{
			Calculadora calc = ConstruirClasse();
			calc.Soma(1, 2);
			calc.Subtracao(2, 1);
			calc.Multiplicacao(2, 2);
			calc.Divisao(2, 1);
			
			var lista = calc.Historico();

			Assert.NotEmpty(lista);
			Assert.Equal(3, lista.Count);
		}




	}
}
