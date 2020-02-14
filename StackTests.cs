using Dimitrije;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Dimitrije.Tests
{
    [TestFixture()]
    public class StackTests
    {

        [Test()]
        public void PushTest_PushNull_ArgumentNullException()
        {
            Stack<string> stack = new Stack<string>();

            Assert.That(() => stack.Push(null), Throws.ArgumentNullException);

        }
        [Test()]
        public void PushTest_PushObj_ElementPushed()
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("asd");
            var a = stack.Peek();
            Assert.AreEqual(a, "asd");
        }
        [Test()]
        public void PopTest_PoppingAnElement_ReturnsElement()
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("asd");
            string tmp = stack.Pop();
            Assert.AreEqual(tmp, "asd");
            Assert.That(() => stack.Pop(), Throws.Exception);
        }
        [Test()]
        public void PopTest_PoppingAnElement_ReturnsException()
        {
            Stack<string> stack = new Stack<string>();

            Assert.That(()=> stack.Pop(), Throws.Exception);
        }
        [Test()]
        public void PeekTest_PeekingWhileEmpty_ReturnsException()
        {
            Stack<string> stack = new Stack<string>();

            Assert.That(() => stack.Peek(), Throws.InvalidOperationException);
        }
        [Test()]
        public void PeekTest_PeekingWhileNotEmpty_ReturnsElement()
        {
            Stack<string> stack = new Stack<string>();

            stack.Push("asd");
            stack.Push("ddt");

            var ele = stack.Peek();

            Assert.AreEqual(ele, "ddt");
        }

    }
}