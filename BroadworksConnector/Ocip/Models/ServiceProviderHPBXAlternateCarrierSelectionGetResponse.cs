using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderHPBXAlternateCarrierSelectionGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "processCbcCarrierSelection", IsNullable = false)]
    public bool ProcessCbcCarrierSelection { get; set; }
    [XmlElement(ElementName = "preselectedLocalCarrier", IsNullable = false)]
    public string PreselectedLocalCarrier { get; set; }
    [XmlElement(ElementName = "preselectedDistantCarrier", IsNullable = false)]
    public string PreselectedDistantCarrier { get; set; }
 }
}
