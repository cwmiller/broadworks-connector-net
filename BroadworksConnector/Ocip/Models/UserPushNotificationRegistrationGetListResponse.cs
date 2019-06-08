using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPushNotificationRegistrationGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _registrationsTable;

    [XmlElement(ElementName = "registrationsTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable RegistrationsTable {
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
