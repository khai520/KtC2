using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtC_2
{
    internal class Bike
    {
        int id;
        string ten;
        string hsx;

        public int Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Hsx { get => hsx; set => hsx = value; }

        public Bike()
        {
        }

        public Bike(int id, string ten, string hsx)
        {
            this.id = id;
            this.ten = ten;
            this.hsx = hsx;
        }
        public void inThongTin()
        {
            Console.WriteLine($"{id} - {ten} - {hsx}");
        }
    }
}
