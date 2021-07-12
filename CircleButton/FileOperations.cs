using System;
using System.IO;

// ===============================
// AUTHOR       :   Mohsen Parisay (m_parisa@encs.concordia.ca)
// CREATE DATE  :   June 8, 2018
// PURPOSE      :   User study prototype to measure the accuracy and performance of eye tracking techniques.
// ===============================

namespace CircleButton
{
    class FileOperations
    {       
        private String DART_FILE_PATH = "C:\\TEMP\\UserStudy\\Dart\\";

        public void WriteToFile(int userId, String testingMode, String data)
        {
            String localDate = DateTime.Now.ToString("yyyy_MM_dd_HHmmss");
            String fileName = DART_FILE_PATH + "USER_" + userId + "_" + testingMode + "_" + localDate + ".csv";
            File.WriteAllText(fileName, data);
        }

        public void SavePointerMovements(int userId, String testingMode, String data)
        {
            String localDate = DateTime.Now.ToString("yyyy_MM_dd_HHmmss");
            String fileName = DART_FILE_PATH + "USER_" + userId + "_" + testingMode + "_movements_" + localDate + ".csv";
            File.WriteAllText(fileName, data);
        }

    }
}
