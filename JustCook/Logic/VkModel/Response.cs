using System;
using System.Collections.Generic;

namespace Logic.Vk
{
	public class Response<T>
	{
		public int count { get; set; }
		public List<T> items { get; set; }
	}
}

