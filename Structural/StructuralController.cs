using DesignPatterns.Structural.Adapter;
using DesignPatterns.Structural.Bridge;
using DesignPatterns.Structural.Composite;
using DesignPatterns.Structural.Decorator;
using DesignPatterns.Structural.Facade;
using DesignPatterns.Structural.Flyweight;
using DesignPatterns.Structural.Proxy;

namespace DesignPatterns.Structural
{
    public class StructuralController
    {
        // Adapter
        public AdapterStructural adapterStrct = new AdapterStructural();
        public AdapterExample adapterExmpl = new AdapterExample();

        // Bridge
        public BridgeStructural bridgeStrct = new BridgeStructural();
        public BridgeExample bridgeExmpl = new BridgeExample();

        // Composite - I was here
        public CompositeStructural compositeStrct = new CompositeStructural();
        public CompositeExample compositeExmpl = new CompositeExample();

        // Decorator
        public DecoratorStructural decoratorStrct = new DecoratorStructural();
        public DecoratorExample decoratorExmpl = new DecoratorExample();

        // Facade
        public FacadeStructural facadeStrct = new FacadeStructural();
        public FacadeExample facadeExmpl = new FacadeExample();

        // Flyweight
        FlyweightStructural flyweightStrct = new FlyweightStructural();
        FlyweightExample flyweightExmpl = new FlyweightExample();

        // Proxy
        public ProxyStructural proxyStrct = new ProxyStructural();
        public ProxyExample proxyExmpl = new ProxyExample();
    }
}
