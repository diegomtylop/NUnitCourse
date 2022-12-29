using System;
namespace NUnitCourse
{
	public class AssertionsTest
	{
		[Test]
		public void AssertionTest()
		{
			string name = "Pepe";
			int age = 17;

			Assert.AreEqual("Pepe", name);

            Assert.AreEqual(age, 21);

			Assert.GreaterOrEqual(age, 18,"Age cannot be less than 18");

            Assert.LessOrEqual(age, 100,"Age cannot be greater than 100");
        }

        [Test]
        public void AssertionArraysTest()
        {
            var farmAnimals = new string[] { "chicken", "pig", "cow" };

            Assert.IsNotEmpty(farmAnimals);

            Assert.Contains("chicken", farmAnimals);
            Assert.Contains("pig", farmAnimals);
            Assert.Contains("cow", farmAnimals);

            Assert.Contains("lion", farmAnimals);

            //Como validar que no contiene un elemento?
        }

        [Test]
        public void AssertionTestContraint()
        {
            string name = "Pepe";
            int age = 21;

            Assert.That(name, Is.EqualTo("Pepe"));

            Assert.That(age, Is.EqualTo(21) );

            Assert.That(age,Is.GreaterThan( 18 ), "Age cannot be less than 18");

            Assert.That(age, Is.LessThanOrEqualTo( 100 ), "Age cannot be greater than 100");
        }

        [Test]
        public void AssertionArraysTestContraint()
        {
            var farmAnimals = new string[] { "chicken", "pig", "cow" };

            Assert.That(farmAnimals, Is.Not.Empty);

            Assert.That( farmAnimals, Does.Contain("chicken") );
            Assert.That(farmAnimals, Does.Contain("pig"));
            Assert.That(farmAnimals, Does.Contain("cow"));

            //Como validar que no contiene un elemento?
            Assert.That(farmAnimals, Does.Not.Contain("lion"));


            Assert.That(farmAnimals, Has.Length.EqualTo(3));

            Assert.That(farmAnimals, Has.Length.EqualTo(3));

            Assert.That(farmAnimals, Has.One.StartsWith("c"));

            //Assert.That(farmAnimals, Has.Some.StartsWith("c"));

        }

        [Test]
        public void AssertionTestCompund()
        {
            string name = "Pepe";
            int age = 21;

            Assert.That(name, Is.EqualTo("Pepe"));

            Assert.That(age, Is.GreaterThan(18)
                .And.LessThanOrEqualTo(100)
                .And.EqualTo(21), "Age should be between 18 and 100");
        }
    }
}