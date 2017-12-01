using DesignPatterns.Behavioral.ChainOfResponsibility;
using DesignPatterns.Behavioral.Command;
using DesignPatterns.Behavioral.Interpreter;
using DesignPatterns.Behavioral.Iterator;
using DesignPatterns.Behavioral.Mediator;
using DesignPatterns.Behavioral.Memento;
using DesignPatterns.Behavioral.Observer;
using DesignPatterns.Behavioral.State;
using DesignPatterns.Behavioral.Strategy;
using DesignPatterns.Behavioral.TemplateMethod;
using DesignPatterns.Behavioral.Visitor;

namespace DesignPatterns.Behavioral
{
    public class BehavioralController
    {
        // Chain of Responsibility
        public ChainOfResponsibilityStructural chainOfResponsibilityStrct = new ChainOfResponsibilityStructural();
        public ChainOfResponsibilityExample chainOfResponsibilityExmpl = new ChainOfResponsibilityExample();

        // Command
        public CommandStructural commandStrct = new CommandStructural();
        public CommandExample commandExmpl = new CommandExample();

        // Interpreter
        public InterpreterStructural interpreterStrct = new InterpreterStructural();
        public InterpreterExample interpreterExmpl = new InterpreterExample();

        // Iterator
        public IteratorStructural iteratorStrct = new IteratorStructural();
        public IteratorExample iteratorExmpl = new IteratorExample();

        // Mediator
        public MediatorStructural mediatorStrct = new MediatorStructural();
        public MediatorExample mediatorExmpl = new MediatorExample();

        // Memento
        public MementoStructural mementoStrct = new MementoStructural();
        public MementoExample memntoExmpl = new MementoExample();

        // Observer
        public ObserverStructural observerStrct = new ObserverStructural();
        public ObserverExample observerExmpl = new ObserverExample();

        // State
        public StateStructural stateStrct = new StateStructural();
        public StateExample stateExmpl = new StateExample();

        // Strategy
        public StrategyStructural strategyStrct = new StrategyStructural();
        public StrategyExample strategyExmpl = new StrategyExample();

        // Template Method
        public TemplateMethodStructural templateMethodStrct = new TemplateMethodStructural();
        public TemplateMethodExample templateMethodExmpl = new TemplateMethodExample();

        // Visitor
        public VisitorStructural visitorStrct = new VisitorStructural();
        public VisitorExample visitorExmpl = new VisitorExample();
    }
}
