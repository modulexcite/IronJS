// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.Expressions.AssignmentOperators
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class SimpleAssignmentTests : SputnikTestFixture
    {
        public SimpleAssignmentTests()
            : base(@"Conformance\11_Expressions\11.13_Assignment_Operators\11.13.1_Simple_Assignment")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.13.1")]
        [TestCase("S11.13.1_A1.js", Description = "White Space and Line Terminator between LeftHandSideExpression and \"=\" or between \"=\" and AssignmentExpression are allowed")]
        public void WhiteSpaceAndLineTerminatorBetweenLeftHandSideExpressionAndOrBetweenAndAssignmentExpressionAreAllowed(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.13.1")]
        [Category("ECMA 16")]
        [TestCase("S11.13.1_A2.1_T1.js", Description = "Operator x = y uses GetValue and PutValue")]
        [TestCase("S11.13.1_A2.1_T2.js", Description = "Operator x = y uses GetValue and PutValue")]
        [TestCase("S11.13.1_A2.1_T3.js", Description = "Operator x = y uses GetValue and PutValue", ExpectedException = typeof(Exception))]
        public void OperatorXYUsesGetValueAndPutValue(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.13.1")]
        [TestCase("S11.13.1_A3.1.js", Description = "Operator x = y PutValue(x, y)")]
        public void OperatorXYPutValueXY(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.13.1")]
        [TestCase("S11.13.1_A3.2.js", Description = "Operator x = y returns GetValue(y)")]
        public void OperatorXYReturnsGetValueY(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.13.1")]
        [TestCase("S11.13.1_A4_T1.js", Description = "AssignmentExpression : LeftHandSideExpression = AssignmentExpression")]
        [TestCase("S11.13.1_A4_T2.js", Description = "AssignmentExpression : LeftHandSideExpression = AssignmentExpression")]
        public void AssignmentExpressionLeftHandSideExpressionAssignmentExpression(string file)
        {
            RunFile(file);
        }
    }
}