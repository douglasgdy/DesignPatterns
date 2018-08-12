using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Visitor
{
    public class MethodDeclaration : Declaration
    {
        public MethodDeclaration(string name) : base(name)
        {
        }

        public override void Accept(IDeclarationVisitor visitor)
        {
            visitor.VisitMethod(this);
            base.Accept(visitor);
        }

        public override IReadOnlyList<Declaration> GetDeclarationChildren()
        {
            return null;
        }
    }
}
