using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderSessionAdmissionControlWhiteListModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "addMatchDigitPattern", IsNullable = false)]
    public List<string> AddMatchDigitPattern { get; set; }
    [XmlElement(ElementName = "deleteMatchDigitPattern", IsNullable = false)]
    public List<string> DeleteMatchDigitPattern { get; set; }
    [XmlElement(ElementName = "enableWhiteList", IsNullable = false)]
    public bool EnableWhiteList { get; set; }
 }
}
