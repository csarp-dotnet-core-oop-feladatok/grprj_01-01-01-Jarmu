using System;
using System.Collections.Generic;
using System.Text;

namespace JarmuProjekt.modell
{
    interface IJarmu
    {
        /// <summary>
        /// A jármű üzemanyagot tankol
        /// </summary>
        /// <param name="uzemanyagMennyiseg">Ennyi üzemanyagot tankol</param>
        /// <exception cref="KivetelTankol">Üzenetét továbbadjuk</exception>
        /// <exception cref="Exception">Üzenetét továbbadjuk</exception>
        void Tankol(double uzemanyagMennyiseg);

        /// <summary>
        /// Új utasok szállnak be a járműbe
        /// </summary>
        /// <param name="beszalloUtasokSzama">Beszálló utasok száma</param>
        /// <exception cref="KivetelUjUtasokBeszallnak">Üzenetét továbbadjuk</exception>
        /// <exception cref="Exception">Üzenetét továbbadjuk</exception>
        void UjUtasokBeszallnak(int beszalloUtasokSzama);

        /// <summary>
        /// Járműből utasok szállnak ki
        /// </summary>
        /// <param name="kiszalloUtasokSzama">Kiszálló utasok száma</param>
        /// <exception cref="KivetelJarmubolUtasokKiszallnak">Üzenetét továbbadjuk</exception>
        /// <exception cref="Exception">Üzenetét továbbadjuk</exception>
        void JarmubolUtasokKiszallnak(int kiszalloUtasokSzama);

        /// <summary>
        /// Jármű utazik adott távolságot
        /// </summary>
        /// <param name="km">Ekkora távolságot utazik a jármű</param>
        /// <exception cref="KivetelUtazik">Üzenetét továbbadjuk</exception>
        /// <exception cref="Exception">Üzenetét továbbadjuk</exception>
        void Utazik(double km);

        /// <summary>
        /// A járműbe új utasok beszállnak, az autó utazik és utasok kiszállnak
        /// </summary>
        /// <param name="tankol">Ennyi üzemanyagot tankol a jármű</param>
        /// <param name="utasBeszal">Ennyi új utas száll be</param>
        /// <param name="km">Ennyi távolságot tesz meg az autó</param>
        /// <param name="utasKiszal">Ennyi utas száll ki</param>
        /// <exception cref="KivetelTankol">Üzenetét továbbadjuk</exception>
        /// <exception cref="KivetelUjUtasokBeszallnak">Üzenetét továbbadjuk</exception>
        /// <exception cref="KivetelUtazik">Üzenetét továbbadjuk</exception>
        /// <exception cref="KivetelJarmubolUtasokKiszallnak">Üzenetét továbbadjuk</exception> 
        /// <exception cref="Exception">Üzenetét továbbadjuk</exception>
        void Utazik(int utasBeszal, double km, int utasKiszal);

        /// <summary>
        /// A jármű tankol, új utasok beszállnak, az autó utazik és utasok kiszállnak
        /// </summary>
        /// <param name="tankol">Ennyi üzemanyagot tankol a jármű</param>
        /// <param name="utasBeszal">Ennyi új utas száll be</param>
        /// <param name="km">Ennyi távolságot tesz meg az autó</param>
        /// <param name="utasKiszal">Ennyi utas száll ki</param>
        /// <exception cref="KivetelTankol">Üzenetét továbbadjuk</exception>
        /// <exception cref="KivetelUjUtasokBeszallnak">Üzenetét továbbadjuk</exception>
        /// <exception cref="KivetelUtazik">Üzenetét továbbadjuk</exception>
        /// <exception cref="KivetelJarmubolUtasokKiszallnak">Üzenetét továbbadjuk</exception> 
        /// <exception cref="Exception">Üzenetét továbbadjuk</exception>
        void Utazik(double tankol, int utasBeszal, double km, int utasKiszal);
    }
}
