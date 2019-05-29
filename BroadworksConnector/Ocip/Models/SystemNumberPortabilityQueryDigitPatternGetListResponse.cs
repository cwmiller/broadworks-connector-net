using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemNumberPortabilityQueryDigitPatternGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "statusDigitPatternTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable StatusDigitPatternTable { get; set; }
 }
}
