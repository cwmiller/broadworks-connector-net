using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPushNotificationRegistrationGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "registrationsTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable RegistrationsTable { get; set; }
 }
}
