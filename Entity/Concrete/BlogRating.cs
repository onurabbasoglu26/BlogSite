﻿using System;
namespace Entity.Concrete
{
	public class BlogRating
	{
		public int BlogRatingId { get; set; }
		public int BlogId { get; set; }
		public int BlogTotalScore { get; set; }
		public int BlogRatingCount { get; set; }
	}
}

