using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo_List_HashSet_SortedSet.Models
{
    public class PessoaComSortedSet : Pessoa, IComparable<PessoaComSortedSet>
    {
        public int CompareTo(PessoaComSortedSet other)
        {
            // Ordenar por idade (crescente)
            var resultado =  Idade.CompareTo(other.Idade);
            return resultado;
            // Ordenar por idade (decrescente)
            //return other.Idade.CompareTo(Idade);
        }
    }
}