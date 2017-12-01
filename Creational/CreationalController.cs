using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.Prototype;
using DesignPatterns.Creational.Singleton;

namespace DesignPatterns.Creational
{
    public class CreationalController
    {
        // Abstract Factory
        public AFactoryStructural AFactoryStrct = new AFactoryStructural();
        public AFactoryExample AFactoryExmpl = new AFactoryExample();

        // Builder
        public BuilderStructural BuilderStrct = new BuilderStructural();
        public BuilderExample BuilderExmpl = new BuilderExample();

        // Factory Method
        public FactoryMethStructural FactoryMethStrct = new FactoryMethStructural();
        public FactoryMethExample FactoryMethExmpl = new FactoryMethExample();

        //Prototype
        public PrototypeStructural PrototypeStrct = new PrototypeStructural();
        public PrototypeExample PrototypeExmpl = new PrototypeExample();

        // Singleton
        public SingletonStructural SingletonStrct = new SingletonStructural();
        public SingletonExample SingletonExmpl = new SingletonExample();
    }
}
