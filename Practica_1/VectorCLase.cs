using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;

namespace Practica_1
{
    class Vector
    {
        Punto _inicio;
        Punto _final;
        double _magnitud;

        


        public Vector(Punto inicio, Punto final)
        {
            _inicio = new Punto(inicio.cordenadax, inicio.cordenaday);
            _final = new Punto(final.cordenadax, final.cordenaday);
        }
        public Vector(double multiplicacion)
        {
            _magnitud = multiplicacion;
        }

        public Vector(float x_inicio, float y_inicio, float x_final, float y_final)
        {
            _inicio = new Punto(x_final, y_final);
            _final = new Punto(x_inicio, y_final);
        }

        //calculo de una maginitud 
        public void calcular_magnitud()
        {
            _magnitud = Math.Sqrt(Math.Pow((_final.cordenadax - _inicio.cordenadax), 2) + Math.Pow((_final.cordenaday - _inicio.cordenaday), 2));
        }


        //sobrecarga de resta
        public static Vector operator -(Vector restado1, Vector restado2)
        {
            Punto nuevo_origen = new Punto(restado1._inicio.cordenadax - restado2._inicio.cordenadax, restado1._inicio.cordenaday - restado2._inicio.cordenaday);
            Punto nuevo_final = new Punto(restado1._final.cordenadax - restado2._final.cordenadax, restado1._final.cordenaday - restado2._final.cordenaday);

            return new Vector(nuevo_origen, nuevo_final);
        }


        public double magnitud
        {
            get { return _magnitud; }
            set { _magnitud = value; }

        }



        // sobre carga de una multiplicacion escalar
        public static Vector operator *(Vector total1, Vector total2)
        {
            return new Vector(total1._magnitud * total2._magnitud);

        }


        //sobre carga de multiplicacion por un vector
        public int[] vector_ = { 1, 2, 3, 4, };
        public int[] vector_1 = { 1, 2, 3, 4, };
        public int[] vec_ = { 1, 2, 3, 4 };
        public Vector(int[] multipicacion_vector)
        {
            vector_ = multipicacion_vector;
            vector_1 = multipicacion_vector;
            vec_ = multipicacion_vector;
        }
        //primera prueba
        private Vector multiplicacion_vectornormal()
        {
            Vector multipicacion = new Vector(20,0, 30,0);
            Vector vectorResult = new Vector();
            double scalar1 = 30;

            vectorResult = multipicacion * scalar1;

            return vectorResult;
        }
        //mi otra prueba
        public static Vector operator *(Vector vector_mul, Vector vector1_mul)
        {
            return new Vector(vector_mul.vector_ * vector_mul.vector_1);           //no se puede aplicar para vectores la multiplicacion
        }



        //tercera prueba
        public static Vector operator *(Vector v1, Vector v2)
        {                                                                               //tampoco me da
            Vector mul = new Vector();
            for (int f = 0; f < 4; f++)
            {
                mul.vec_[f] = v1.vec_[f] + v2.vec_[f];
            }
            return mul;
        }









    }
}


