using System.Collections.Generic;

namespace CSharp_Tips.Collections
{
    /// <summary>
    /// Esses quatro métodos são usados para remover itens de uma lista em .NET, mas cada um deles tem uma funcionalidade diferente.
    /// Lembre-se de que esses métodos modificam a lista original e que o índice das posições na lista começa em 0. 
    /// Certifique-se de usar o método correto para a sua finalidade e passar os parâmetros corretos para evitar erros em tempo de execução.
    /// </summary>
    public static class DifferenceBetweenRemovals
    {
        /// <summary>
        /// Remove: Remove o primeiro item da lista que corresponde ao objeto especificado.
        /// </summary>
        public static void UsingRemove()
        {
            List<int> myList = new List<int> { 1, 2, 3, 4, 5 };
            myList.Remove(3); // Remove o número 3 da lista
        }

        /// <summary>
        /// RemoveAll: Remove todos os itens da lista que correspondem ao predicado especificado.
        /// </summary>
        public static void UsingRemoveAll()
        {
            List<int> myList = new List<int> { 1, 2, 3, 4, 5 };
            myList.RemoveAll(x => x % 2 == 0); // Remove todos os números pares da lista
        }

        /// <summary>
        /// RemoveAt: Remove o item da lista na posição especificada.
        /// </summary>
        public static void UsingRemoveAt()
        {
            List<int> myList = new List<int> { 1, 2, 3, 4, 5 };
            myList.RemoveAt(2); // Remove o número 3 da lista
        }

        /// <summary>
        /// RemoveRange: Remove uma sequência de itens da lista começando na posição especificada e com o comprimento especificado.
        /// </summary>
        public static void UsingRemoveRange()
        {
            List<int> myList = new List<int> { 1, 2, 3, 4, 5 };
            myList.RemoveRange(1, 3); // Remove os números 2, 3 e 4 da lista
        }
    }
}
