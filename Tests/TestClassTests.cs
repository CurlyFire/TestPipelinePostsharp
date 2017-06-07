using System;
using ConsoleApp;
using NUnit.Framework;
using FluentAssertions;

namespace Tests
{
    [TestFixture]
    public class TestClassTests
    {
        [Test]
        public void ShouldThrowIfPostsharpWasWeaved()
        {
            var test = new TestClass();
            Action action = () => test.DoSomething();
            action.ShouldThrow<Exception>().WithMessage("Thrown from postsharp");
        }
    }
}
