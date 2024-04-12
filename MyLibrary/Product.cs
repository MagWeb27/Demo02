﻿namespace MyLibrary
{
    public class Product(int id, string name, decimal unitPrice, int unitsInStock)
    {
        public int Id => id;
        public string Name => name;
        public decimal UnitPrice => unitPrice;
        public int UnitsInStock => unitsInStock;
        public bool Discontinued {  get; private set; }
        public void SetDiscontinued() => Discontinued = true;
        public bool GetStatus() => Discontinued;
    }
}
