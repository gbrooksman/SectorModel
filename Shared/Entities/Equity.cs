using System;


namespace SectorModel.Shared.Entities
{
    public class Equity : BaseEntity
    {
        public Equity()
        {
            
        }

        public Guid Id {get; set;}
        public string SymbolName { get; set; }

        public string Symbol { get; set; }

        public bool IsSelected { get; set; }
}
}