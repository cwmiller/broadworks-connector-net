using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemGroupNightForwardingGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "nightForwardInterGroupCallsWithinEnterprise", IsNullable = false)]
    public bool NightForwardInterGroupCallsWithinEnterprise { get; set; }
 }
}
