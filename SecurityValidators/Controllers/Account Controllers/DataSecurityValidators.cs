namespace SecurityValidators.DataSecurityValidators.Controllers
{
    public static class DataSecurityValidators
    {
        // Simvolu yoxlayir
        public static bool HasAtSymbol(this string email)
        {
            return email.Contains("@");
        }
        // Uzunlugu 8 cox olmalidi
        public static bool IsPasswordLengthValid(this string password)
        {
            return password.Length > 8;
        }

    }
}
