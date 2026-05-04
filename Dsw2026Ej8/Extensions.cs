namespace Dsw2026Ej8
{
    internal static class Extensions
    {
        public static string ToProductCode(this string code)
        {
            if (string.IsNullOrEmpty(code))
            { 
                return "SIN-CODFGO";
            }
            else
            {
                code = code.Trim();
                code = code.ToUpper();
                code = code.Replace(" ", "-");
                return code;
            }
        }
    }
}
