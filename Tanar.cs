using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace Karesz
{
    public partial class Form1 : Form
    {
        string betöltendő_pálya = "palya005.txt";

        void TANÁR_ROBOTJAI()
        {
            new Robot("Karesz", 10, 10, 10, 10, 5, 1, 1, 2);


            Robot janesz = new Robot("Janesz", Robot.képkészlet_lilesz, 0, 0, 0, 0, 1500, 1, 28, 0);
            

            janesz.Feladat = delegate ()
            {
                while (pálya.MiVanItt(new Vektor(2, 29)) == sárga)
                { 
                    janesz.Lőjj();
                    for (int j = 0; j < 7; j++)
                    {
                        janesz.Várj();
                    }

                }
            };

            Robot paresz = new Robot("paresz", Robot.képkészlet_lilesz, 0, 0, 0, 0, 1500, 2, 28, 0);


            paresz.Feladat = delegate ()
            {
                while (pálya.MiVanItt(new Vektor(2, 29)) == sárga)
                {
                    paresz.Lőjj();
                    for (int j = 0; j < 7; j++)
                    {
                        paresz.Várj();
                    }

                }
            };

            Robot matyesz = new Robot("matyesz", Robot.képkészlet_lilesz, 0, 0, 0, 0, 1500, 3, 28, 0);

            matyesz.Feladat = delegate ()
            {
                while (pálya.MiVanItt(new Vektor(2, 29)) == sárga)
                {
                    matyesz.Lőjj();
                    for (int j = 0; j < 7; j++)
                    {
                        matyesz.Várj();
                    }

                }
            };

        }
    }
}
