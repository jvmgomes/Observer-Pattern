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
            Pcd river = (Pcd) s;

            double temp = river.getTemp();
            double ph = river.getPh();
            double umid_ar = river.getUmid();
            Console.WriteLine("Medições da " + universityName);
            Console.WriteLine("Rio monitorado: " + river.getRiverName());
            Console.WriteLine("Temperatura Celsius: " + temp);
            Console.WriteLine("Ph da água: " + ph);
            Console.WriteLine("Umidade do ar: " + umid_ar + "%");
            Console.WriteLine("\n");
        
        
        }
    }
}