using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_Tips.Collections
{
	public class DifferenceBetweenListIQueryableIEnumerator
	{
		private readonly List<Product> products1 = new List<Product> {
			new Product { ID = 1, Name = "Name1" }, new Product { ID = 2, Name = "Name2" },new Product { ID = 3, Name = "Name3" },
		};

		public void Start()
		{
			ManageIEnumerable();
			ManageIQueryable();
			ManageList();
		}

		private void ManageIEnumerable()
		{
			/*
			 Enquanto consulta informações no banco de dados, IEnumerable executa uma consulta Select no lado do servidor, 
			carrega os dados na memória do cliente e então filtra os dados. (mais trabalho, mais lenta)
			 */

			IEnumerable<Product> _enumerable = products1.Where(x => x.ID > 1);
			IEnumerator<Product> enumerator = _enumerable.GetEnumerator();

			while (enumerator.MoveNext())
			{
				Console.WriteLine(enumerator.Current.ID + " - " + enumerator.Current.Name);
			};
			//enumerator.Reset();

			var _result = _enumerable.First(x => x.ID == 3);
		}

		private void ManageIQueryable()
		{
			/*
			 Enquanto consulta informações no banco de dados, 
			IQueryable executa uma consulta Select no lado do servidor com todos os filtros. (menos trabalho, mais rápida)
			 */

			IQueryable<Product> _iqueryable = products1.Where(x => x.ID > 1).AsQueryable();			
			var _result = _iqueryable.First(x => x.ID == 3);

		}

		private void ManageList()
		{
			List<Product> _list = products1.Where(x => x.ID > 1).ToList();

			var _result = _list.First(x => x.ID == 3);

			_list.Add(new Product { ID = 10, Name = "User10" });


		}
	}

	public class Product
	{
		public int ID { get; set; }
		public string Name { get; set; }
	}
}
