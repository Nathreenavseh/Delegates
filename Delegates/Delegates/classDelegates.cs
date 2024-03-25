namespace MySolutions
{
    public class Delegates
    {
        public void Odd(int[] numbers)
        {
            foreach (int num in numbers){
                if(num%2 != 0) Console.Write($"{num} ");
            }

        }
        public void Even(int[] numbers)
        {
            foreach (int num in numbers){
                if(num%2 == 0) Console.Write($"{num} ");
            }
        }
        
        public void Simple(int[] numbers)
        {
            foreach (int num in numbers){
                int counter = 0;
                for(int i = 1; i<num; i++){
                    if(num%i == 0){
                        counter++;
                    }
                }
                if(counter== 1) Console.Write($"{num} ");
            }
        }
        
        public void Fibonachi(int[] numbers)
        {
            numbers[0] = 0; 
            numbers[1] = 1;
    
            for (int i = 2; i < numbers.Length; i++){
                numbers[i] = numbers[i - 1] + numbers[i - 2]; // Вычисляем следующее число Фибоначчи
            } 
        }
    }
}