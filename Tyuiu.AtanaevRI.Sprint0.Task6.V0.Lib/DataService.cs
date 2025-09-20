namespace Tyuiu.AtanaevRI.Sprint0.Task6.V0.Lib
{
    public class DataService
    {
        // Сумма элементов массива
        public static int AdditionArray(int[] numbers)
        {
            var total = 0;
            for (var index = 0; index < numbers.Length; index++)
            {
                total += numbers[index];
            }
            return total;
        }

        // Разность элементов массива
        public static int SubstractionArray(int[] numbers)
        {
            var total = 0;
            int index = 0;
            while (index < numbers.Length)
            {
                total -= numbers[index];
                index++;
            }
            return total;
        }

        // Произведение элементов массива
        public static int MultiplicationArray(int[] numbers)
        {
            int total = 1;
            int index = 0;
            do
            {
                total *= numbers[index];
                index++;
            } while (index < numbers.Length);
            return total;
        }
    }
}