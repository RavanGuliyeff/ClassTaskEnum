namespace Core.Helpers.Exceptions
{
    internal class PriceMustBeGratherThanZeroException:Exception
    {
        public PriceMustBeGratherThanZeroException(string msg = "Price must be greater than 0!\n") : base(msg) { }
    }
}
