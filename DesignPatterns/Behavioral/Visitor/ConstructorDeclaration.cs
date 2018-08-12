using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Visitor
{
    public class ConstructorDeclaration : Declaration
    {
        public ConstructorDeclaration() : base("Constructor")
        {
        }

        public override void Accept(IDeclarationVisitor visitor)
        {
            visitor.VisitConstructor(this);
            base.Accept(visitor);
        }

        public override IReadOnlyList<Declaration> GetDeclarationChildren()
        {
            return null;
        }
    }
}
