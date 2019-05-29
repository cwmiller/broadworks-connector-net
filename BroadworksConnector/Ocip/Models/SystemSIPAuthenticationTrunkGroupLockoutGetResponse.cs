using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSIPAuthenticationTrunkGroupLockoutGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "lockoutTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable LockoutTable { get; set; }
 }
}
