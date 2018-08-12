using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Visitor
{
    public class NamespaceDeclaration : Declaration
    {
        private readonly ClassDeclaration[] classDeclarations;

        public NamespaceDeclaration(string name, params ClassDeclaration[] classDeclarations) : base(name)
        {
            this.classDeclarations = classDeclarations;
        }

        public override void Accept(IDeclarationVisitor visitor)
        {
            visitor.VisitNamespace(this);
            base.Accept(visitor);
        }

        public override IReadOnlyList<Declaration> GetDeclarationChildren()
        {
            return this.classDeclarations;
        }
    }
}
