using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Visitor
{
    public class Sample
    {
        public static void Start()
        {
            var @namespace = 
                new NamespaceDeclaration("DesignPatterns.Behavioral.Visitor",
                    new ClassDeclaration("Sample", 
                        new ConstructorDeclaration(), new MethodDeclaration("Start")));

            Console.WriteLine("Visit declaration's name:");
            @namespace.Accept(new DeclarationNameVisitor());
            Console.WriteLine("Visit declaration's children total:");
            @namespace.Accept(new DeclarationChildrenVisitor());
        }
    }
}
