using NUnit.Framework;
using System;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Frends.Community.Utilities.Tests
{
    [TestFixture]
    class TestClass
    {
        [Test]
        public void TestEcho()
        {
            var ret = SmallFUnctions.Echo("foobar");
            Assert.That(ret, Is.EqualTo("foobar"));
        }


        [Test]
        public void TestAlwaysTrue()
        {
            var ret = SmallFUnctions.AlwaysTrue();
            Assert.That(ret, Is.EqualTo(true));
        }

        [Test]
        public void TestThrowExpection()
        {
            try
            {
                SmallFUnctions.ThrowException("ErrorTest");
            }
            catch (Exception e)
            {
                Assert.That(e.Message, Is.EqualTo("ErrorTest"));
            }

        }


        public class Person
        {
            /// <summary>
            /// Type of an object.
            /// </summary>
            public string Name { get; set; }
            /// <summary>
            /// Object serialized to human-readable string.
            /// </summary>
            public int Age { get; set; }

        }

        [Test]
        public void TestDump()
        {

            string json = @"[
              'Small',
              'Medium',
              'Large'
            ]";

            JArray a = JArray.Parse(json);

            var cycleJson = JObject.Parse(@"{""name"":""john""}");

            var persons = new List<Person>
            {
                new Person { Name = "John", Age = 20, },
                new Person { Name = "Thomas", Age = 30, },
            };

            var ret = SmallFUnctions.Dump(a);

            Assert.That(ret.ConsoleStyle, Is.EqualTo("ErrorTest"));
            

        }





    }
}

