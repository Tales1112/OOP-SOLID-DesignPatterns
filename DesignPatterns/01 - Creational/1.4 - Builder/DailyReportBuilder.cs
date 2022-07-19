using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns._01___Creational._1._4___Builder
{
    public class DailyReportBuilder : IFurnitureInventoryBuilder
    {
        private InventoryReport _report;
        private IEnumerable<FurnitureItem> _items;
        public DailyReportBuilder(IEnumerable<FurnitureItem> items)
        {
            Reset();
            _items = items; 
        }

        public IFurnitureInventoryBuilder AddDimensions()
        {
            _report.DimensionsSection =  string.Join(Environment.NewLine, _items.Select(product =>
            $"Product: {product.Name} \nPrice: {product.Price} \n" +
            $"Height: {product.Height} x Widht: {product.Width} -> weight: {product.Weight} lbs"));
            return this;
        }

        public IFurnitureInventoryBuilder AddLogistics(DateTime dateTime)
        {
            _report.LogisticsSection = $"Report generate on {dateTime}";
            return this;
        }

        public IFurnitureInventoryBuilder AddTitle()
        {
            _report.TitleSection = "------- Daily Inventory Report --------- \n\n";
            return this;
        }

        public InventoryReport GetDailyReport()
        {
            InventoryReport finishedReport = _report;
            Reset();

            return finishedReport;
        }

        public void Reset()
        {
            _report = new InventoryReport();
        }
    }
}
