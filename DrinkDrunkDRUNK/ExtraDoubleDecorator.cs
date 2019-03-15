namespace DrinkDrunkDRUNK
{  
      public class ExtraDoubleDecorator : ExtraAdditionDecorator
    {
        public ExtraDoubleDecorator(Consumation consumation)
        {
            this.consumation = consumation;
        }

        public override decimal getPrice()
        {
            return consumation.getPrice() * 2;
        }

        public override string getProductName()
        {
            return consumation.getProductName() + " double";
        }
    }
}