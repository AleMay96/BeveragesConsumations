namespace DrinkDrunkDRUNK
{
    public abstract class Consumation
    {
        protected string productName = " ";
        public virtual string getProductName()
        {
            return productName;
        }
        public abstract decimal getPrice();
    }
}