namespace DrinkDrunkDRUNK
{
    public abstract class ExtraAdditionDecorator : Consumation
    {
        protected Consumation consumation;

        public override abstract string getProductName();

    }
}