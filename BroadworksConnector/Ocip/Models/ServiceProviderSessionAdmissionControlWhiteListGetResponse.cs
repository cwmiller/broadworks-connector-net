using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderSessionAdmissionControlWhiteListGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "matchDigitPattern", IsNullable = false)]
    public List<string> MatchDigitPattern { get; set; }
    [XmlElement(ElementName = "enableWhiteList", IsNullable = false)]
    public bool EnableWhiteList { get; set; }
 }
}
