using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teste1
{
    public class Aluna
    {
        //Atributos
     public string nome;
     public double nota1, nota2;

      //Vou criar 3 metódos.
     //Média
     public double media()
     {
        return (nota1+nota2)/2;
     }

    //Situação
     public string situacao(double media)
     {
        if(media >=7)
         return "Aprovado";
         else 
          return "Reprovado";   
     }
   
    //Mensagem
    public void Mensagem()
    {   //Obter Média
        double obterMedia = media();
        //Obter a situação
        string obterSituacao= situacao(obterMedia);
       
        //Mensagem
        Console.WriteLine($"{nome} foi {obterSituacao} com média {obterMedia}.");
    }
    }
}