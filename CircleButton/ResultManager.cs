using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleButton
{
    class ResultManager
    {
        private FileOperations fo = new FileOperations();
        private int VALID_DISTANCE = 90;

        public void WriteResults(int userId, String testingMode, List<String> measurements)
        {
            String data = testingMode + "\n" + CreateData(measurements);
            fo.WriteToFile(userId, testingMode, data);            
        }

        public void SavePointerMovements(int userId, String testingMode, List<String> pointerMovements)
        {
            String data = CreateData(pointerMovements);
            fo.SavePointerMovements(userId, testingMode, data);
        }

        private String CreateData(List<String> inputData)
        {
            StringBuilder sb = new StringBuilder();            
            foreach (String item in inputData)
            {
                sb.Append(item);
                sb.Append("\n");
            }
            sb.Append("\n");

            return sb.ToString();
        }

        public String CalculateDistance(int x, int y, int current_X_Currsor, int current_Y_Cursor)
        {
            int diff_X = Math.Abs(x - current_X_Currsor);
            int diff_Y = Math.Abs(y - current_Y_Cursor);

            double deltaX = Math.Pow(diff_X, 2);
            double deltaY = Math.Pow(diff_Y, 2);
            double distance = Math.Sqrt(deltaX + deltaY);

            if (distance > VALID_DISTANCE)
            {
                distance = VALID_DISTANCE;
            }

            String finalDistance = distance.ToString("0.##");
            return finalDistance;
        }
    }
}
