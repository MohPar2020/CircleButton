using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleButton
{


    class CursorManager
    {
        int xPosition = -1;
        int yPosition = -1;        

        public void UpdateCursor(int x, int y)
        {
            xPosition = x;
            yPosition = y;
        }

        public int[] GetCursorPosition()
        {
            int[] position = new int[2];
            position[0] = xPosition;
            position[1] = yPosition;
            return position;
        }

    }
}
