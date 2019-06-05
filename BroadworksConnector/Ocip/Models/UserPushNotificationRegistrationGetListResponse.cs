using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPushNotificationRegistrationGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _registrationsTable;

    [XmlElement(ElementName = "registrationsTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable RegistrationsTable {
        get => _registrationsTable;
        set {
            RegistrationsTableSpecified = true;
            _registrationsTable = value;
        }
    }

    [XmlIgnore]
    public bool RegistrationsTableSpecified { get; set; }
}
}
