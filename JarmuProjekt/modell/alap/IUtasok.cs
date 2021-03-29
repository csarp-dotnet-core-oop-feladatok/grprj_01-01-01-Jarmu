using System;
using System.Collections.Generic;
using System.Text;

namespace _12GroupWork.model
{
    interface IUtasok
    {
        /// <summary>
        /// Utasok beszállnak a járműbe
        /// </summary>
        /// <param name="jarmubeBeszalloUtasokSzama"></param>
        public void Beszall(int passangerNumber);
        /// <summary>
        /// Utasok kiszállnak a járműből
        /// </summary>
        /// <param name="kisszaloUtasokSzama"></param>
        public void Kiszall(int newPassangerNumber);
    }
}
