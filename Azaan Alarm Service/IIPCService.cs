using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace Azaan
{
    [ServiceContract]
    public interface IIPCService
    {
        [OperationContract]
        bool srvcSetTime(String namaz, DateTime t);
        [OperationContract]
        bool srvcGetTime(String namaz, out DateTime t);
        [OperationContract]
        bool srvcSetActive(String namaz, bool activ);
        [OperationContract]
        bool srvcGetActive(out bool[] activ);
        [OperationContract]
        bool srvcGetWaiting(out String namaz);
        /*
        [OperationContract]
        bool callService(string inAct, out string strRes);
         * */
    }
}
