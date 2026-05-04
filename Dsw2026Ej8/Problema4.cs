namespace Dsw2026Ej8
{
    internal class Problema4
    {
        public double CalculateAverage(int? nota1, int? nota2, int? nota3) {
            {
                int sum = 0;
                int count = 0;
                if (nota1.HasValue && 0 <= nota1.Value && nota1.Value <= 10)
                {
                    sum += nota1.Value;
                    count++;
                }
                if (nota2.HasValue && 0 <= nota2.Value && nota2.Value <= 10)
                {
                    sum += nota2.Value;
                    count++;
                }
                if (nota3.HasValue && 0 <= nota3.Value && nota3.Value <= 10)
                {
                    sum += nota3.Value;
                    count++;
                }
                return count > 0 ? (double)sum / count : 0.0;
            }
        }
    }
}
