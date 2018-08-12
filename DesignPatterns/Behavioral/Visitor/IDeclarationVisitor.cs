using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Visitor
{
    public interface IDeclarationVisitor
    {
        void VisitNamespace(NamespaceDeclaration declaration);
        void VisitClass(ClassDeclaration declaration);
        void VisitConstructor(ConstructorDeclaration declaration);
        void VisitMethod(MethodDeclaration declaration);
    }
}
