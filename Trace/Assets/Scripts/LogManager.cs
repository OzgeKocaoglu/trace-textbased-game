using UnityEngine;

class LogManager : ILog
{

    //TODO: Singleton Log Manager??
    public static string log = "log manager is available";

    public string getLog()
    {
        return log;
    }

    public void printLog(string log)
    {
        Debug.Log("merbs");
    }

}
