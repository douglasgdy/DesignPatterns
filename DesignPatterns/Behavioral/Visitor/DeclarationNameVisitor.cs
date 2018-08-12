using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Visitor
{
    public class DeclarationNameVisitor : IDeclarationVisitor
    {
        public void VisitClass(ClassDeclaration declaration)
        {
            Console.WriteLine($"Good to see you, {declaration.Name}.");
        }

        public void VisitConstructor(ConstructorDeclaration declaration)
        {
            Console.WriteLine($"Good to see you, {declaration.Name}.");
        }

        public void VisitMethod(MethodDeclaration declaration)
        {
            Console.WriteLine($"Good to see you, {declaration.Name}.");
        }

        public void VisitNamespace(NamespaceDeclaration declaration)
        {
            Console.WriteLine($"Good to see you, {declaration.Name}.");
        }
    }
}
