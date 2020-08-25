using UnityEngine;

class LogManager : ILog
{
    string log;

    public string getLog()
    {
        return "log manager is available";
    }

    public void printLog(string log)
    {
        Debug.Log("merbs");
    }

    public void setLog(string log)
    {
        if(log != null)
        {
            this.log = log;
        }
    }
}
