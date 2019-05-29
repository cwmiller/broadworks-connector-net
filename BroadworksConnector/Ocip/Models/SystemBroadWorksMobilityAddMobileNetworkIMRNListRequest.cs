using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBroadWorksMobilityAddMobileNetworkIMRNListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "mobileNetworkName", IsNullable = false)]
    public string MobileNetworkName { get; set; }
    [XmlElement(ElementName = "imrnNumber", IsNullable = false)]
    public List<string> ImrnNumber { get; set; }
    [XmlElement(ElementName = "numberRange", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.DNRange> NumberRange { get; set; }
 }
}
