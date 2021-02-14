using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_Tips.Collections
{
	public class DifferenceBetweenLists
	{
		private readonly List<string> list1 = new List<string> { "name1", "name2", "name3", "name4" };
		private readonly List<string> list2 = new List<string> { "name1", "name2", "name5" };

		private readonly List<User> users1 = new List<User> {
			new User { ID = 1, Name = "Name1" }, new User { ID = 2, Name = "Name2" },new User { ID = 3, Name = "Name3" },
		};
		private readonly List<User> users2 = new List<User> {
			new User { ID = 1, Name = "Name1" }, new User { ID = 2, Name = "Name2" }
		};

		public void Start()
		{
			DifferenceBetweenStrings();
			DifferenceBetweenObjects();

		}

		private void DifferenceBetweenStrings()
		{
			Console.WriteLine("DifferenceBetweenStrings");
			var differences = list1.Except(list2).ToList();
			differences.AddRange(list2.Except(list1));
			Console.WriteLine(differences.Count());
			Console.WriteLine("END-DifferenceBetweenStrings");
		}

		private void DifferenceBetweenObjects()
		{
			Console.WriteLine("DifferenceBetweenObjects");
			var differences = users1.Except(users2, new IdComparer());
			Console.WriteLine(differences.Count());
			Console.WriteLine("END-DifferenceBetweenObjects");
		}
	}

	public class User
	{
		public int ID { get; set; }
		public string Name { get; set; }
	}

	public class IdComparer : IEqualityComparer<User>
	{
		public int GetHashCode(User co)
		{
			if (co == null)
			{
				return 0;
			}
			return co.ID.GetHashCode();
		}

		public bool Equals(User x1, User x2)
		{
			if (object.ReferenceEquals(x1, x2))
			{
				return true;
			}
			if (object.ReferenceEquals(x1, null) ||
				object.ReferenceEquals(x2, null))
			{
				return false;
			}
			return x1.ID == x2.ID;
		}
	}
}
