
namespace Tests
{
    using NUnit.Framework;
    using ExtendedDatabase;
    using System;
    using NUnit.Framework.Constraints;

    public class ExtendedDatabaseTests
    {
        private Person gosho;
        private Person pesho;
        private Person kiro;
        private ExtendedDatabase database;

        [SetUp]
        public void TestInit()
        {
            gosho = new Person(1122, "Gosho");
            pesho = new Person(112233, "Pesho");
            kiro = new Person(11223344, "Kiro");

            this.database = new ExtendedDatabase();

        }

        [Test]
        public void ConstructorShouldInitializeCollection()
        {
            var expected = new Person[] { pesho, gosho };
            this.database = new ExtendedDatabase(expected);

            Assert.AreEqual(2, this.database.Count, $"Constructor doesn't work with {typeof(Person)} as parametar");
        }

        [Test]

        public void DatabaseAddPerson()
        {
            var person = new Person(111L, "Test");

            this.database.Add(person);

            Assert.AreEqual(1, this.database.Count, $"Add {typeof(Person)} doesn't work");
        }

        [Test]
        [TestCase(1L, "1L", 1L, "1L")]
        [TestCase(1L, "1L", 10L, "1L")]
        [TestCase(1L, "1L", 1L, "10L")]
        public void CanNotAddPersonWithAlreadyExistingUsernameOrId(long firstId, string firstUsername, long secondId, string secondUsername)
        {
            var firstPerson = new Person(firstId, firstUsername);
            var secPerson = new Person(secondId, secondUsername);

            this.database.Add(firstPerson);

            Assert.Throws<InvalidOperationException>(() => this.database.Add(secPerson));
        }
        [Test]
        public void RemovePersonFromDatabase()
        {
            database.Add(kiro);
            database.Add(gosho);

            database.Remove();
            database.Remove();

            Assert.AreEqual(0, this.database.Count);            
        }

        [Test]
        [TestCase(1L, "1L", 2L, "2L", 3L, "3L", 1L)]
        [TestCase(1L, "1L", 2L, "2L", 3L, "3L", 2L)]
        [TestCase(1L, "1L", 2L, "2L", 3L, "3L", 3L)]

        public void FindById(long firstId, string firstUsername, long secondId, string secondUsername, long thirdId, string thirdUsername, long keyId)
        {
            // Arrange
            this.database.Add(new Person(firstId, firstUsername));
            this.database.Add(new Person(secondId, secondUsername));
            this.database.Add(new Person(thirdId, thirdUsername));

            // Act
            var foundPerson = this.database.FindById(keyId);

            // Assert
            Assert.AreEqual(keyId, foundPerson.Id, $"Found {typeof(Person)} by Id is not the desired one");
        }


        [Test]
        [TestCase(1L, "1L", 2L, "2L", 3L, "3L", "1L")]
        [TestCase(1L, "1L", 2L, "2L", 3L, "3L", "2L")]
        [TestCase(1L, "1L", 2L, "2L", 3L, "3L", "3L")]
        public void FindByUsername(long firstId, string firstUsername, long secondId, string secondUsername, long thirdId, string thirdUsername, string keyUsername)
        {
            // Arrange
            this.database.Add(new Person(firstId, firstUsername));
            this.database.Add(new Person(secondId, secondUsername));
            this.database.Add(new Person(thirdId, thirdUsername));

            // Act
            var foundPerson = this.database.FindByUsername(keyUsername);

            // Assert
            Assert.AreEqual(keyUsername, foundPerson.UserName, $"Found {typeof(Person)} by Username is not the desired one");
        }

        [Test] 
        public void CannotFindUnexistenId()
        {
            database.Add(kiro);

            Assert.Throws<InvalidOperationException>(() => database.FindById(2));
        }


        [Test]
        public void CannotFindNegativeId()
        {
            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => this.database.FindById(-1));
        }

        [Test]
        public void CannotFindUnexistentUsername()
        {
            // Arrange 
            this.database.Add(kiro);

            // Assert
            Assert.Throws<InvalidOperationException>(() => this.database.FindByUsername("fiRst"));
        }

        [Test]
        public void CannotFindUsernameNull()
        {
            // Arrange 
            this.database.Add(kiro);

            // Assert
            Assert.Throws<ArgumentNullException>(() => this.database.FindByUsername(null));
        }
    }
}