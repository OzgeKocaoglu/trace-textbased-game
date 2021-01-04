using UnityEngine;
using System.Collections.Generic;

class LogManager
{

    //TODO: Singleton Log Manager??
    //TODO: Add set log and use console.
    public static string log = "main log manager";
    public string staticLog = @" 
Font: OCR-A   Reflection: no   Adjustment: left   Stretch: no
                                               _____ ____    _      ____ _____ 
                                              |____ |___ \  / \    / _  |_   _|
                                                |_  |   | |/ _ \  | (_| | | |  
                                               ___| |___| / ___ \  > _  | | |  
                                              |_____|____/_/   \_\/_/ |_| |_|  
                                                                              ";

    public int maxMessages = 25;

    public void sendLog(string text)
    {
      
    }
   
    public string printLog()
    {
        return staticLog;
    }


}
