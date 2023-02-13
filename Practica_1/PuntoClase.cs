using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
    //punto 
     class Punto
    {
        private float _cordenadax;
        private float _cordenaday;
        
        public Punto(float x, float y)
        {
            _cordenadax = x;
            _cordenaday = y;
            
        }
        //setters y getters para un punto
        public float cordenadax
        {
            get { return _cordenadax; }
            set { _cordenadax = value;}
        }

        public float cordenaday
        {
            get { return _cordenaday; }
            set { _cordenaday = value;}

        }

        ~Punto()
        {

        }




    }
}
