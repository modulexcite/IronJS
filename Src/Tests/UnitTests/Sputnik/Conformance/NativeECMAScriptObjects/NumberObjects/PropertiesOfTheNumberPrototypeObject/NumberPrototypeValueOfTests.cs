// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.NumberObjects.PropertiesOfTheNumberPrototypeObject
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class NumberPrototypeValueOfTests : SputnikTestFixture
    {
        public NumberPrototypeValueOfTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.7_Number_Objects\15.7.4_Properties_of_the_Number_Prototype_Object\15.7.4.4_Number.prototype.valueOf")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.7.4.4")]
        [TestCase("S15.7.4.4_A1_T01.js", Description = "Number.prototype.valueOf() returns this number value")]
        [TestCase("S15.7.4.4_A1_T02.js", Description = "Number.prototype.valueOf() returns this number value")]
        public void NumberPrototypeValueOfReturnsThisNumberValue(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.7.4.4")]
        [TestCase("S15.7.4.4_A2_T01.js", Description = "The valueOf function is not generic, it cannot be transferred to other kinds of objects for use as a method and there is should be a TypeError exception if its this value is not a Number object")]
        [TestCase("S15.7.4.4_A2_T02.js", Description = "The valueOf function is not generic, it cannot be transferred to other kinds of objects for use as a method and there is should be a TypeError exception if its this value is not a Number object")]
        [TestCase("S15.7.4.4_A2_T03.js", Description = "The valueOf function is not generic, it cannot be transferred to other kinds of objects for use as a method and there is should be a TypeError exception if its this value is not a Number object")]
        [TestCase("S15.7.4.4_A2_T04.js", Description = "The valueOf function is not generic, it cannot be transferred to other kinds of objects for use as a method and there is should be a TypeError exception if its this value is not a Number object")]
        [TestCase("S15.7.4.4_A2_T05.js", Description = "The valueOf function is not generic, it cannot be transferred to other kinds of objects for use as a method and there is should be a TypeError exception if its this value is not a Number object")]
        public void TheValueOfFunctionIsNotGenericItCannotBeTransferredToOtherKindsOfObjectsForUseAsAMethodAndThereIsShouldBeATypeErrorExceptionIfItsThisValueIsNotANumberObject(string file)
        {
            RunFile(file);
        }
    }
}