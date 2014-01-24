namespace VectorLib.Tests
{
	using System;
	using NUnit.Framework;

	// ReSharper disable InconsistentNaming
	// ReSharper disable PossibleNullReferenceException

	[TestFixture]
	public class Vector3Fixture
	{
		private Vector3 SUT;

		[SetUp]
		public void Vector3_SetUp()
		{
			SUT = new Vector3(2, 4, 2);
		}

		[Test]
		public void Length_ShouldBeCalculatedToBeSqrt24()
		{
			var value = Math.Sqrt(24);

			Assert.That(SUT.Length, Is.EqualTo(value));
		}
		[Test]
		public void Operator_VectorTimesVector_ShouldReturnTheDotProductOfBothVectors()
		{
			var vector  = new Vector3(3, 7, -2);
			var actual  = SUT * vector;

			Assert.That(actual, Is.EqualTo(30));
		}

		[Test]
		public void Operator_VectorTimesScalar_ShouldReturnVector3MultipliedByScalar()
		{
			var expected  = new Vector3(10, 20, 10);
			var actual    = SUT * 5;

			Assert.That(actual, Is.EqualTo(expected));
		}

		[Test]
		public void ToString_ShouldReturnVectorNotation()
		{
			var expected = "<2,4,2>";
			var value    = SUT.ToString();

			Assert.That(value, Is.EqualTo(expected));
		}

		[Test]
		public void Equals_ShouldEqualEquivalentVector3()
		{
			var value = new Vector3(2, 4, 2);

			Assert.That(SUT, Is.AssignableTo(typeof (IEquatable<Vector3>)));
			Assert.That(SUT, Is.EqualTo(value));
		}

		[Test]
		public void Vector3Cross_ShouldBeImplementedProperly()
		{
			var expected  = new Vector3(-22, 10, 2);
			var vector    = new Vector3(3, 7, -2);
			var actual    = Vector3.Cross(SUT, vector);

			Assert.That(actual, Is.EqualTo(expected));
		}
	}

	// ReSharper enable InconsistentNaming
	// ReSharper enable PossibleNullReferenceException
}
