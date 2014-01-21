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
		public void Vector3MultiplicationOperator_ImplementsTheDotOperator_ShouldBeImplementedProperly()
		{
			var vector = new Vector3(3, 7, -2);

			var value  = SUT * vector;

			Assert.That(value, Is.EqualTo(30));
		}
	}

	// ReSharper enable InconsistentNaming
	// ReSharper enable PossibleNullReferenceException
}
