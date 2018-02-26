using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuizPGM.Desk;

namespace QuizPGM.Test
{
	[TestClass]
	public class PrincipalTest
	{
		[TestMethod]
		public void CriandoTelaInicial()
		{
			Principal iniTela = new Principal();
			Assert.IsNotNull(iniTela);
		}
	}
}
