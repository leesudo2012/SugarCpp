﻿using Antlr4.StringTemplate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SugarCpp.Compiler
{
    public abstract class Stmt : AstNode
    {
    }

    public class StmtIf : Stmt
    {
        public Expr Condition;
        public StmtBlock Body;
        public StmtBlock Else;

        public override Template Accept(Visitor visitor)
        {
            return visitor.Visit(this);
        }
    }

    public class StmtWhile : Stmt
    {
        public Expr Condition;
        public StmtBlock Body;

        public override Template Accept(Visitor visitor)
        {
            return visitor.Visit(this);
        }
    }

    public class StmtFor : Stmt
    {
        public Expr Start;
        public Expr Condition;
        public Expr Next;
        public StmtBlock Body;

        public override Template Accept(Visitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}