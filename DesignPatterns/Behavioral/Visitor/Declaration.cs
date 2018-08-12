using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Visitor
{
    public abstract class Declaration
    {
        protected Declaration(string name)
        {
            this.Name = name;
        }

        public string Name { get; }

        public IReadOnlyList<Declaration> Children
        {
            get
            {
                return GetDeclarationChildren();
            }
        }

        public abstract IReadOnlyList<Declaration> GetDeclarationChildren();

        public virtual void Accept(IDeclarationVisitor visitor)
        {
            if (Children != null)
            {
                foreach (var declaration in Children)
                {
                    declaration.Accept(visitor);
                }
            }
        }
    }
}
