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

        public string getUniversityName()
        {
            return universityName;
        }
        public void update (Subject s)
        {
            double temp = ((Pcd) s).getTemp();
            double ph = ((Pcd) s).getPh();
            double umid_ar = ((Pcd) s).getUmid();
            Console.WriteLine("Medições da " + universityName);
            Console.WriteLine("Temperatura Celsius: " + temp);
            Console.WriteLine("Ph da água: " + ph);
            Console.WriteLine("Umidade do ar: " + umid_ar + "%");
            Console.WriteLine("\n");
        
        
        }
    }
}