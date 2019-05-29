using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPrivacyGetAvailableMonitorsUserListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "availableMonitorsTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable AvailableMonitorsTable { get; set; }
 }
}
