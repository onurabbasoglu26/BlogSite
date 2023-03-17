using System;
using System.Collections.Generic;
using Entity.Concrete;

namespace Business.Abstract
{
	public interface IWriterService : IGenericService<Writer>
	{
		List<Writer> GetWriterById(int id);
	}
}

