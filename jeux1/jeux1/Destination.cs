using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeux1
{
   public class Destination
    {
        public int posX;
        public int posY;

        public Destination(int posX, int posY)
        {
            this.posX = posX;
            this.posY = posY;
        }

        public int getPosX()
        {
            return this.posX;
        }

        public int getPosY()
        {
            return this.posY;
        }


        public void setPosX(int posX)
        {
            this.posX = posX;
        }

        public void setPosY(int posY)
        {
            this.posY = posY;
        }
    }
}
