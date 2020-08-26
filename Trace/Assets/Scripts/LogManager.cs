using UnityEngine;

class LogManager : ILog
{

    //TODO: Singleton Log Manager??
    //TODO: Add set log and use console.
    public static string log = "main log manager";
    public static string staticLog = @" 
Font: OCR-A   Reflection: no   Adjustment: left   Stretch: no
                                               _____ ____    _      ____ _____ 
                                              |____ |___ \  / \    / _  |_   _|
                                                |_  |   | |/ _ \  | (_| | | |  
                                               ___| |___| / ___ \  > _  | | |  
                                              |_____|____/_/   \_\/_/ |_| |_|  
                                                                               ";

    public string getLog()
    {
        return staticLog;
    }

    public string getDinamicLog()
    {
        return log;
    }

}
