using System;

namespace TodoLambda.Domain.Entity
{
    public class Item
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public bool IsChecked { get; set; }
    }
}