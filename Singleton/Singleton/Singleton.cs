using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{

    class Singleton
    {
        private static Singleton _instance; //Instancia privada

        private Singleton() { } //Constructor privado

        public static Singleton GetInstance() //Metodo para obtener la instancia
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }

        public static void someBusinessLogic()
        {
            // ...
        }
    }
}
