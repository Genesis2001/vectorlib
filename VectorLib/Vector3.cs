// -----------------------------------------------------------------------------
//  <copyright file="Vector3.cs" company="Zack Loveless">
//      Copyright (c) Zack Loveless.  All rights reserved.
//  </copyright>
// -----------------------------------------------------------------------------

namespace VectorLib
{
	using System;

	public class Vector3
	{
		public Vector3(double x, double y, double z)
		{
			X = x;
			Y = y;
			Z = z;
		}

		public double X { get; private set; }

		public double Y { get; private set; }

		public double Z { get; private set; }

		public double Length
		{
			get { return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2)); }
		}

		#region

		public static double Cross(Vector3 a, Vector3 b)
		{
			throw new NotImplementedException();
		}

		public static double Cross(Vector3 a, Vector3 b, Vector3 c)
		{
			throw new NotImplementedException();
		}

		#endregion
		
		#region Operators

		public static Vector3 operator +(Vector3 a, Vector3 b)
		{
			return new Vector3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
		}

		public static double operator *(Vector3 a, Vector3 b)
		{
			// Dot product

			return (a.X * b.X) + (a.Y * b.Y) + (a.Z * b.Z);
		}

		#endregion
	}
}
