using System;

namespace Observer_Pattern
{   
    public class University : IObserver
    {
        private string universityName;
        public University(String name)
        {
            setUniversityName(name);
        }

        public void setUniversityName(String name)
        {
            this.universityName = name;
        }
        public void update (Subject s)
        {
            double temp = ((Pcd) s).getTemp();
            double ph = ((Pcd) s).getTemp();
            double umid_ar = ((Pcd) s).getTemp();
            Console.WriteLine("Temperatura Celsius: " + temp);
            Console.WriteLine("Ph da água: " + ph);
            Console.WriteLine("Umidade do ar: " + umid_ar + "%");
        
        
        }
    }
}