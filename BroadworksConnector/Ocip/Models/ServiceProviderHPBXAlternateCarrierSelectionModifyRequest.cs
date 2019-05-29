using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderHPBXAlternateCarrierSelectionModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "processCbcCarrierSelection", IsNullable = false)]
    public bool ProcessCbcCarrierSelection { get; set; }
    [XmlElement(ElementName = "preselectedLocalCarrier", IsNullable = true)]
    public string PreselectedLocalCarrier { get; set; }
    [XmlElement(ElementName = "preselectedDistantCarrier", IsNullable = true)]
    public string PreselectedDistantCarrier { get; set; }
 }
}
