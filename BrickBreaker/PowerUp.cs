using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BrickBreaker
{
    internal class PowerUp
    {
        public int speed, x, y, size;
        public string powerUpType; 
        public static Random Random = new Random();

        public PowerUp( int _x, int _y, int _speed, int _size)
        {
            speed = _speed;
            x = _x;
            y = _y;
            size = _size;
        }

        public void Move()
        {
            y = y + speed;
        }
        public bool PaddleCollide(Paddle p)
        {
            Rectangle powerUpRec = new Rectangle(x, y, size, size);
            Rectangle paddleRec = new Rectangle(p.x, p.y, p.width, p.height);

            if (powerUpRec.IntersectsWith(paddleRec))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void PowerUpChoice()
        {
            int powerUpchoice = Random.Next(1, 11);
            //increase length of  (comment back in after testing others)
            if (powerUpchoice > 8)
            {
                powerUpType = "Long Paddle";
            }
            //add life
            else if (powerUpchoice == 2)
            { powerUpType = "Add Life"; }
            //speed up paddle and shorten it
            else if (powerUpchoice == 3 || powerUpchoice == 4 || powerUpchoice == 5)
            {
                powerUpType = "Short Paddle";
            }
            else if (powerUpchoice == 6 || powerUpchoice == 7)
            { //increase ball size
                powerUpType = "Large Ball";
            }
        }
    }
}
