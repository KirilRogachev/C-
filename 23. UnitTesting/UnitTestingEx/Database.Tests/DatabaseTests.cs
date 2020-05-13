namespace Tests
{
    using NUnit.Framework;
    using System.Linq;
    using Database;
    using System;

    public class DatabaseTests
    {
       
        [Test]
         public void ConstructorShouldBeInitializeWith16Elements()
        {
            int[] array = new int[16];
            Database database = new Database(array);

            int expectedCount = 16;
            int actualCount = database.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void ConstructorShouldThrowInvalidOperationExeptionIsNotExactly16()
        {

            int[] array = new int[17];
            Assert.Throws<InvalidOperationException>(() => new Database(array));
        }
        [Test]
        public void AddMethodShouldAddCorrectlyAndIncreaceTheCount()
        {
            Database database = new Database();
            database.Add(1);

            int expectedCount = 1;
            int actualCount = database.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }
        [Test]
        public void AddMethodSchouldAddOnNextEmptyIndex()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            Database database = new Database(array);

            database.Add(6);

            int expectedIndex = 6;
            int actualIndex = database.Fetch()[5];

            Assert.AreEqual(expectedIndex, actualIndex);
        }
        [Test]
        public void AddMethodShouldThrowInvalidOperationExceptionWhenElementsAreExceeded()
        {
            int[] array = new int[16];
            Database database = new Database(array);

            Assert.Throws<InvalidOperationException>(() => database.Add(1));
        }
        [Test]
        public void shouldRemoveCorrectlyAndDecreaseCount()
        {
            int[] array = { 1, 2, 3 };
            Database database = new Database(array);
            database.Remove();

            int expectedCount = 2;
            int actualCount = database.Count;
            Assert.AreEqual(expectedCount, actualCount);

        }
        [Test]
        public void shouldRemoveCorrectlyLastElement()
        {
            int[] array = { 1, 2, 3 };
            Database database = new Database(array);
            database.Remove();

            int expectedCount = 2;
            int actualCount = database.Fetch()[1];
            Assert.AreEqual(expectedCount, actualCount);

        }
    }
}