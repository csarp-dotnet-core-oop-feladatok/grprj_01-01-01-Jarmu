using System;
using System.Collections.Generic;
using System.Text;

namespace JarmuProjekt.modell
{
    interface IUzemanyagTartaly
    {
        /// <summary>
        /// Jármű tankol adott üzemanyag mennyiséget
        /// </summary>
        /// <param name="ujUzemanyagMennyiseg">Ennyit tankol a jármű</param>
        /// <exception cref="KivetelTolt">Ennyi üzemanyag nem fér a tartályba.</exception>
        void Tolt(double uzemanyagMennyiseg);
        /// <summary>
        /// A jármű adott fogyasztással utazik adott hosszúságú utat. 
        /// Ekkor a fogyasztásnak megfelelően csökken a tartályban lévő üzemanyaga
        /// </summary>
        /// <param name="megtettUtHossza">Ennyi km-t utazik a jarmű </param>
        /// <param name="fogyasztas">100 km-en ennyit fogyaszt a jármű </param>
        void UzemanyagFogyas(double megtettUtHossza,double fogyasztas);
    }
}
