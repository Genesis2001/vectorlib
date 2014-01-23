// -----------------------------------------------------------------------------
//  <copyright file="Vector3.cs" company="Zack Loveless">
//      Copyright (c) Zack Loveless.  All rights reserved.
//  </copyright>
// -----------------------------------------------------------------------------

namespace VectorLib
{
	using System;

	public struct Vector3 : IEquatable<Vector3>
	{
		public Vector3(double x, double y, double z) : this()
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

		#region Static modifiers
		
		public static Vector3 Cross(Vector3 a, Vector3 b)
		{
			double x, y, z;

			x = a.Y * b.Z - a.Z * b.Y;
			y = (a.X * b.Z - a.Z * b.X) * -1;
			z = a.X * b.Y - a.Y * b.X;

			return new Vector3(x, y, z);
		}

		public static double Distance(Vector3 a, Vector3 b)
		{
			throw new NotImplementedException();
		}

		#endregion
		
		#region Operators

		public static Vector3 operator +(Vector3 a, Vector3 b)
		{
			return new Vector3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
		}

		/// <summary>
		/// Implements the dot product for two <see cref="T:Vector3" /> instances.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		public static double operator *(Vector3 a, Vector3 b)
		{
			// Dot product
			return a.X * b.X + a.Y * b.Y + a.Z * b.Z;
		}

		public static Vector3 operator *(Vector3 a, double s)
		{
			// Vector-Scalar multiplcation
			return new Vector3(a.X * s, a.Y * s, a.Z * s);
		}

		#endregion

		#region Implementation of IEquatable<Vector3>

		/// <summary>
		/// Indicates whether the current object is equal to another object of the same type.
		/// </summary>
		/// <returns>
		/// true if the current object is equal to the <paramref name="other"/> parameter; otherwise, false.
		/// </returns>
		/// <param name="other">An object to compare with this object.</param>
		public bool Equals(Vector3 other)
		{
			return X == other.X && Y == other.Y && Z == other.Z;
		}

		#endregion

		#region Overrides of ValueType

		/// <summary>
		/// Returns the fully qualified type name of this instance.
		/// </summary>
		/// <returns>
		/// A <see cref="T:System.String"/> containing a fully qualified type name.
		/// </returns>
		public override string ToString()
		{
			return string.Format("<{0}>", string.Join(",", X, Y, Z));
		}

		#endregion
	}
}
