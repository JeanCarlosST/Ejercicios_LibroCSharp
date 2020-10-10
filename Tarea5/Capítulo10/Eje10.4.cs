using System;

namespace Cap10
{
    public class PoligonoV
    {
        public int NoLados { 
            get
            {
                return NoLados;
            } 
            set
            {
                if(value < 3)
                    NoLados = 3;
                else    
                    NoLados = value;
            } 
        }
        public float[] LongitudLados 
        { 
            get
            {
                return LongitudLados;
            } 
            set
            {
                bool ladosValidos = true;

                foreach(float i in value)
                {
                    if(i <= 0)
                    {
                        ladosValidos = false;
                        break;
                    }
                }

                if(!ladosValidos || value.Length != NoLados)
                    LongitudLados = new float[NoLados];
                
                else    
                    LongitudLados = value;
            } 
        }
        public float Base { 
            get
            {
                return Base;
            } 
            set
            {
                if(value <= 0)
                    Base = 1;
                else    
                    Base = value;
            } 
        }
        public float Altura {
            get
            {
                return Altura;
            } 
            set
            {
                if(value <= 0)
                    Altura = 1;
                else    
                    Altura = value;
            } 
        }

        public PoligonoV()
        {
            NoLados = 0;
            Base = 0f;
            Altura = 0f;
        }

        public PoligonoV(float base_, float altura)
        {
            this.Base = base_;
            this.Altura = altura;
        }

        public PoligonoV(int noLados, float[] longitudLados)
        {
            this.NoLados = noLados;
            this.LongitudLados = longitudLados;
        }

        public PoligonoV(float base_, float altura, int noLados, float[] longitudLados)
        {
            this.Base = base_;
            this.Altura = altura;
            this.NoLados = noLados;
            this.LongitudLados = longitudLados;
        }
    }
}