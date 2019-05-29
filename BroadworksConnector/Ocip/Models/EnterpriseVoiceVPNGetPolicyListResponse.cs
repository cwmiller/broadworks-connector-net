using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseVoiceVPNGetPolicyListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "locationList", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable LocationList { get; set; }
 }
}
