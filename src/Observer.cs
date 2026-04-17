using System;

namespace Observer_Pattern
{
    public interface IObserver
    { 
        public void update (Subject s)  ;
    }
}