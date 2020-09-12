using System;

namespace IBB_BodyMassIndexCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            double bodyWeight = 0;
            double bodyHeight = 0;
            double bodyMassIndex = 0;

            Console.Write("Lütfen vücut ağırlığınızı giriniz(kg): ");
            bodyWeight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Lütfen boy uzunluğunuzu giriniz(cm): ");
            bodyHeight = Convert.ToDouble(Console.ReadLine());
            bodyHeight = meterConverter(bodyHeight);

            bodyMassIndex = idealWeightCalculator(bodyWeight,bodyHeight);

            if(bodyMassIndex<18.49){
                Console.WriteLine("Vücut kitle indeksiniz: {0}, bundan dolayı ideal kilonun altındasınız.", bodyMassIndex);
                Console.ReadKey();
            }else if(bodyMassIndex<24.99){
                Console.WriteLine("Vücut kitle indeksiniz: {0}, ideal kilodasınız.", bodyMassIndex);
                Console.ReadKey();
            }else if(bodyMassIndex<29.99){
                Console.WriteLine("Vücut kitle indeksiniz: {0}, bundan dolayı ideal kilonun üzerindesiniz.", bodyMassIndex);
                Console.ReadKey();
            }else{
                Console.WriteLine("Vücut kitle indeksiniz: {0}, bundan dolayı ideal kilonun çok üzerindesiniz.", bodyMassIndex);
                Console.ReadKey();
            }
        }

        static double meterConverter(double Height)
        {
            Height = Height / 100;
            return Height;
        }

        static double idealWeightCalculator(double Weight, double Height)
        {
            double bodyMassIndex = 0;
            bodyMassIndex = Weight / Math.Pow(Height, 2);
            return bodyMassIndex;
        }
    }
}
