using System;

namespace DesignPatterns._01___Creational._1._4___Builder
{
    public class InventoryBuilderDirectory
    {
        private IFurnitureInventoryBuilder _builder;

        public InventoryBuilderDirectory(IFurnitureInventoryBuilder builder)
        {
            _builder = builder;
        }


        public void BuildCompleteReport()
        {
            _builder.AddTitle();
            _builder.AddDimensions();
            _builder.AddLogistics(DateTime.Now);
        }
    }
}
