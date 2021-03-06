// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.Expressions.AdditiveOperators
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class TheAdditionOperatorTests : SputnikTestFixture
    {
        public TheAdditionOperatorTests()
            : base(@"Conformance\11_Expressions\11.6_Additive_Operators\11.6.1_The_Addition_operator")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.6.1")]
        [Category("ECMA 7.2")]
        [Category("ECMA 7.3")]
        [TestCase("S11.6.1_A1.js", Description = "White Space and Line Terminator between AdditiveExpression and \"+\" or between \"+\" and MultiplicativeExpression are allowed")]
        public void WhiteSpaceAndLineTerminatorBetweenAdditiveExpressionAndOrBetweenAndMultiplicativeExpressionAreAllowed(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.6.1")]
        [TestCase("S11.6.1_A2.1_T1.js", Description = "Operator x + y uses GetValue")]
        [TestCase("S11.6.1_A2.1_T2.js", Description = "Operator x + y uses GetValue")]
        [TestCase("S11.6.1_A2.1_T3.js", Description = "Operator x + y uses GetValue")]
        public void OperatorXYUsesGetValue(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.6.1")]
        [Category("ECMA 8.6.2.6")]
        [TestCase("S11.6.1_A2.2_T1.js", Description = "Operator x + y uses [[Default Value]]")]
        [TestCase("S11.6.1_A2.2_T2.js", Description = "Operator x + y uses [[Default Value]]")]
        [TestCase("S11.6.1_A2.2_T3.js", Description = "Operator x + y uses [[Default Value]]")]
        public void OperatorXYUsesDefaultValue(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.6.1")]
        [TestCase("S11.6.1_A2.3_T1.js", Description = "ToNumber(first expression) is called first, and then ToNumber(second expression)")]
        public void ToNumberFirstExpressionIsCalledFirstAndThenToNumberSecondExpression(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.6.1")]
        [TestCase("S11.6.1_A2.4_T1.js", Description = "First expression is evaluated first, and then second expression")]
        [TestCase("S11.6.1_A2.4_T2.js", Description = "First expression is evaluated first, and then second expression")]
        [TestCase("S11.6.1_A2.4_T3.js", Description = "First expression is evaluated first, and then second expression")]
        public void FirstExpressionIsEvaluatedFirstAndThenSecondExpression(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.6.1")]
        [TestCase("S11.6.1_A3.1_T1.1.js", Description = "If Type(Primitive(x)) is not String and Type(Primitive(y)) is not String, then operator x + y returns ToNumber(x) + ToNumber(y)")]
        [TestCase("S11.6.1_A3.1_T1.2.js", Description = "If Type(Primitive(x)) is not String and Type(Primitive(y)) is not String, then operator x + y returns ToNumber(x) + ToNumber(y)")]
        [TestCase("S11.6.1_A3.1_T1.3.js", Description = "If Type(Primitive(x)) is not String and Type(Primitive(y)) is not String, then operator x + y returns ToNumber(x) + ToNumber(y)")]
        [TestCase("S11.6.1_A3.1_T2.1.js", Description = "If Type(Primitive(x)) is not String and Type(Primitive(y)) is not String, then operator x + y returns ToNumber(x) + ToNumber(y)")]
        [TestCase("S11.6.1_A3.1_T2.2.js", Description = "If Type(Primitive(x)) is not String and Type(Primitive(y)) is not String, then operator x + y returns ToNumber(x) + ToNumber(y)")]
        [TestCase("S11.6.1_A3.1_T2.3.js", Description = "If Type(Primitive(x)) is not String and Type(Primitive(y)) is not String, then operator x + y returns ToNumber(x) + ToNumber(y)")]
        [TestCase("S11.6.1_A3.1_T2.4.js", Description = "If Type(Primitive(x)) is not String and Type(Primitive(y)) is not String, then operator x + y returns ToNumber(x) + ToNumber(y)")]
        [TestCase("S11.6.1_A3.1_T2.5.js", Description = "If Type(Primitive(x)) is not String and Type(Primitive(y)) is not String, then operator x + y returns ToNumber(x) + ToNumber(y)")]
        public void IfTypePrimitiveXIsNotStringAndTypePrimitiveYIsNotStringThenOperatorXYReturnsToNumberXToNumberY(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.6.1")]
        [TestCase("S11.6.1_A3.2_T1.1.js", Description = "If Type(Primitive(x)) is String or Type(Primitive(y)) is String, then operator x + y returns the result of concatenating ToString(x) followed by ToString(y)")]
        [TestCase("S11.6.1_A3.2_T1.2.js", Description = "If Type(Primitive(x)) is String or Type(Primitive(y)) is String, then operator x + y returns the result of concatenating ToString(x) followed by ToString(y)")]
        [TestCase("S11.6.1_A3.2_T2.1.js", Description = "If Type(Primitive(x)) is String or Type(Primitive(y)) is String, then operator x + y returns the result of concatenating ToString(x) followed by ToString(y)")]
        [TestCase("S11.6.1_A3.2_T2.2.js", Description = "If Type(Primitive(x)) is String or Type(Primitive(y)) is String, then operator x + y returns the result of concatenating ToString(x) followed by ToString(y)")]
        [TestCase("S11.6.1_A3.2_T2.3.js", Description = "If Type(Primitive(x)) is String or Type(Primitive(y)) is String, then operator x + y returns the result of concatenating ToString(x) followed by ToString(y)")]
        [TestCase("S11.6.1_A3.2_T2.4.js", Description = "If Type(Primitive(x)) is String or Type(Primitive(y)) is String, then operator x + y returns the result of concatenating ToString(x) followed by ToString(y)")]
        public void IfTypePrimitiveXIsStringOrTypePrimitiveYIsStringThenOperatorXYReturnsTheResultOfConcatenatingToStringXFollowedByToStringY(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.6.1")]
        [Category("ECMA 11.6.3")]
        [TestCase("S11.6.1_A4_T1.js", Description = "The result of an addition is determined using the rules of IEEE 754 double-precision arithmetics")]
        [TestCase("S11.6.1_A4_T2.js", Description = "The result of an addition is determined using the rules of IEEE 754 double-precision arithmetics")]
        [TestCase("S11.6.1_A4_T3.js", Description = "The result of an addition is determined using the rules of IEEE 754 double-precision arithmetics")]
        [TestCase("S11.6.1_A4_T4.js", Description = "The result of an addition is determined using the rules of IEEE 754 double-precision arithmetics")]
        [TestCase("S11.6.1_A4_T5.js", Description = "The result of an addition is determined using the rules of IEEE 754 double-precision arithmetics")]
        [TestCase("S11.6.1_A4_T6.js", Description = "The result of an addition is determined using the rules of IEEE 754 double-precision arithmetics")]
        [TestCase("S11.6.1_A4_T7.js", Description = "The result of an addition is determined using the rules of IEEE 754 double-precision arithmetics")]
        [TestCase("S11.6.1_A4_T8.js", Description = "The result of an addition is determined using the rules of IEEE 754 double-precision arithmetics")]
        [TestCase("S11.6.1_A4_T9.js", Description = "The result of an addition is determined using the rules of IEEE 754 double-precision arithmetics")]
        public void TheResultOfAnAdditionIsDeterminedUsingTheRulesOfIEEE754DoublePrecisionArithmetics(string file)
        {
            RunFile(file);
        }
    }
}