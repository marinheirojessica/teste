using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula5
{
    public class Aluno
    {
        //Atributos
        public string ? nome;
        public double nota1, nota2;

        //Metódos
        //Média
        public double media()
        {
            return (nota1+nota2)/2;
        }
        //Situação
        public string situacao(double media)
        {
            return media >=7? "Aprovado" :"Reprovado";
        }
        //Mensagem
        public void Mensagem()
        {
            //Obter Média
            double obterMedia= media();
            //Obter Situação
            string obterSituacao=situacao(obterMedia);

            //Mensagem
            Console.WriteLine($"A aluna {nome} está {obterSituacao}. Média {obterMedia}.");
        }
    }
}