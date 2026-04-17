using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

namespace Observer_Pattern
{
    public class Subject
    {
        private List<IObserver> universities = new List<IObserver>();

        public void addObserver(IObserver university)
        {
            universities.Add(university);
        }

        public void removeObserver(IObserver university)
        {
            universities.Remove(university);
        }

        public void notifyUniversities()
        {
            foreach (IObserver obs in universities)
            {
                obs.update(this);
            }
        }
    }
}