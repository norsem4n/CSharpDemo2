/* Project: Assignment Set 1 - Program 2
 * Developed by: Christopher Karnas
 * Date Created: September 6, 2020
 * Last Modified: September 11, 2020
 * Class Name: Cone
 * Description: A calculation for the area and volume of a cone
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKarnasProgram2
{
    class Cone
    {
        //Calculate and return the surface area of a cone

        public double CalculateArea(int intRadius, int intHeight)
        {
            return Math.PI * intRadius * (intRadius + Math.Sqrt(Math.Pow(intRadius, 2) + Math.Pow(intHeight, 2)));
        }

        //Calculate and return the volume of a cone

        public double CalculateVolume(int intRadius, int intHeight)
        {
            return Math.PI * Math.Pow(intRadius, 2) * intHeight / 3;
        }
    }
}
