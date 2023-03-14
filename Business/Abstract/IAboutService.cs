using System;
using System.Collections.Generic;
using Entity.Concrete;

namespace Business.Abstract
{
	public interface IAboutService
	{
		List<About> GetAboutList();
	}
}

