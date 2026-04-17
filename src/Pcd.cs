using System;

namespace Observer_Pattern
{
    public class Pcd : Subject
    {
        private double temp;
        private double ph;
        private double umid_ar;

        public double getTemp()
        {
            return temp;
        }

        public double getPh()
        {
            return ph;
        }
        public double getUmid()
        {
            return umid_ar;
        }

        public void setTemp(double temp)
        {
            this.temp = temp;
            notifyUniversities();
        }
        public void setPh(double ph)
        {
            this.ph = ph;
            notifyUniversities();
        }
        public void setUmid(double umid_ar)
        {
            this.umid_ar = umid_ar;
            notifyUniversities();
        }
    }
}