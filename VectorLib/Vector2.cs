// -----------------------------------------------------------------------------
//  <copyright file="Vector2.cs" company="Zack Loveless">
//      Copyright (c) Zack Loveless.  All rights reserved.
//  </copyright>
// -----------------------------------------------------------------------------

namespace VectorLib
{
	using System;

	public class Vector2
	{
		public double X { get; set; }

		public double Y { get; set; }

		public double Length
		{
			get { return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2)); }
		}
	}
}
