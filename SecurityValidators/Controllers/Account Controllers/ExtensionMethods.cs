namespace SecurityValidators.ExtensionMethods.Controllers
{
    public static class ExtensionMethods
    {
        public static int CalculateProduct(this int[] array)
        {
        if (array == null || array.Length == 0)
             throw new ArgumentException("Massiv boş və ya sıfır ola bilməz.");

        int product = 1;
         foreach (int num in array)
         {
             product *= num;
         }
            return product;
            
        }
}
}