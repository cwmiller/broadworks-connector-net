using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseSecurityClassificationCustomizationGetAvailableListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "securityClassificationNameTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable SecurityClassificationNameTable { get; set; }
 }
}
