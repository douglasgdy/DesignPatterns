using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Behavioral.Visitor
{
    public class ClassDeclaration : Declaration
    {
        private readonly Declaration[] declarations;

        public ClassDeclaration(string name, params Declaration[] declarations) : base(name)
        {
            this.declarations = declarations;
        }

        public override void Accept(IDeclarationVisitor visitor)
        {
            visitor.VisitClass(this);
            base.Accept(visitor);
        }

        public override IReadOnlyList<Declaration> GetDeclarationChildren()
        {
            return this.declarations;
        }
    }
}
