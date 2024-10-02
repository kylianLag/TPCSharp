using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeux1
{
    public class Personnage
    {
        private int posX;
        private int posY;

        public Personnage(int posX, int posY)
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
