using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autos_doga
{
    internal class Auto
    {
        string rend;
        string mark;
        string model;
        int gyartasev;
        DateTime  forgalmiErvenyesseg;
        int kmAllas;
        int hengerurt;
        int tomeg;
        int teljesitmeny;
        decimal vetelAr;

        public string Rend { get => rend; set => rend = value; }
        public string Mark { get => mark; set => mark = value; }
        public string Model { get => model; set => model = value; }
        public int Gyartasev { get => gyartasev; set => gyartasev = value; }
        public DateTime ForgalmiErvenyesseg { get => forgalmiErvenyesseg; set => forgalmiErvenyesseg = value; }
        public int KmAllas { get => kmAllas; set => kmAllas = value; }
        public int Hengerurt{ get => hengerurt; set => hengerurt = value; }
        public int Tomeg { get => tomeg; set => tomeg = value; }
        public int Teljesitmeny { get => teljesitmeny; set => teljesitmeny = value; }
        public decimal VetelAr { get => vetelAr; set => vetelAr = value; }

        public Auto(string rend, string mark, string model, int gyartasev, DateTime forgalmiErvenyesseg, int kmAllas, int hengerurt, int tomeg, int teljesitmeny, decimal vetelAr)
        {
            Rend = rend;
            Mark = mark;
            Model = model;
            Gyartasev = gyartasev;
            ForgalmiErvenyesseg = forgalmiErvenyesseg;
            KmAllas = kmAllas;
            Hengerurt = hengerurt;
            Tomeg = tomeg;
            Teljesitmeny = teljesitmeny;
            VetelAr = vetelAr;
        }

        public Auto()
        {
        }

        public override string ToString()
        {
            return $"{this.mark}{this.Model}({this.vetelAr})";
        }
    }
}
