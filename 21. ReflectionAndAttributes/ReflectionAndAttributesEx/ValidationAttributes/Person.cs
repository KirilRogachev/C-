namespace ValidationAttributes
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Person
    {
        public Person(string fullName, int age)
        {
            this.FullName = fullName;
            this.Age = age;
        }
        [Obsolete]
        [MyRequired]
        public string FullName { get; set; }
       [MyRange(18,65)]
        public int Age { get; set; }
    }
}
