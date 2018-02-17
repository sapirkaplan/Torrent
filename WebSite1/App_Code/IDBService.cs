using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDBService" in both code and config file together.
[ServiceContract]
public interface IDBService
{
    [OperationContract]
    void DoWork();

    [OperationContract]
    bool checkAuthentication(string userName, string password);

    [OperationContract]
    void addUserToOnlineUsersTable(string userName, int port, string ip);

    [OperationContract]
    void removeUserFromOnlineUsersTable(string userName, int port, string ip);
}
