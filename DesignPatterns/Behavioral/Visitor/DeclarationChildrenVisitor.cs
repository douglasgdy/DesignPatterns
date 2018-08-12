using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Visitor
{
    public class DeclarationChildrenVisitor : IDeclarationVisitor
    {
        public void VisitClass(ClassDeclaration declaration)
        {
            int count = declaration.Children != null ? declaration.Children.Count : 0;
            Console.WriteLine($"{declaration.Name} has {count} children.");
        }

        public void VisitConstructor(ConstructorDeclaration declaration)
        {
            int count = declaration.Children != null ? declaration.Children.Count : 0;
            Console.WriteLine($"{declaration.Name} has {count} children.");
        }

        public void VisitMethod(MethodDeclaration declaration)
        {
            int count = declaration.Children != null ? declaration.Children.Count : 0;
            Console.WriteLine($"{declaration.Name} has {count} children.");
        }

        public void VisitNamespace(NamespaceDeclaration declaration)
        {
            int count = declaration.Children != null ? declaration.Children.Count : 0;
            Console.WriteLine($"{declaration.Name} has {count} children.");
        }
    }
}
