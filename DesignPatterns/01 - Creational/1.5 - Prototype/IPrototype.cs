namespace DesignPatterns._01___Creational._1._5___Prototype
{
    public interface IPrototype
    {
        public void Debug();
        public IPrototype DeppCopy();
        public IPrototype ShallowCopy();
    }
}