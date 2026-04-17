using System;

namespace Observer_Pattern
{
    class Test
    {
        static void Main(String[] args)
        {
            Pcd tapajos = new Pcd();
            Pcd solimoes = new Pcd();
            Pcd negro = new Pcd();
            tapajos.addObserver(new University ("Unifesp"));
            tapajos.addObserver(new University ("Usp"));
            tapajos.addObserver(new University ("Unip"));
            negro.addObserver(new University ("Ufrj"));
            negro.addObserver(new University ("Usp"));
            solimoes.addObserver(new University ("Unip"));
            solimoes.addObserver(new University ("Unifesp"));

            // -----------------------------
            // mudando informações
            tapajos.setPh(7.0);
            solimoes.setUmid(80.0);
            negro.setTemp(20.0);
        }
    }
}