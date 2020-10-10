using System;

namespace Cap10
{
    public class Poligono
    {
        public int NoLados { get; set; }
        public float[] LongitudLados { get; set; }
        public float Base { get; set; }
        public float Altura { get; set; }

        public Poligono()
        {
            NoLados = 0;
            Base = 0f;
            Altura = 0f;
        }

        public Poligono(float base_, float altura)
        {
            this.Base = base_;
            this.Altura = altura;
        }

        public Poligono(int noLados, float[] longitudLados)
        {
            this.NoLados = noLados;
            this.LongitudLados = longitudLados;
        }

        public Poligono(float base_, float altura, int noLados, float[] longitudLados)
        {
            this.Base = base_;
            this.Altura = altura;
            this.NoLados = noLados;
            this.LongitudLados = longitudLados;
        }
    }
}