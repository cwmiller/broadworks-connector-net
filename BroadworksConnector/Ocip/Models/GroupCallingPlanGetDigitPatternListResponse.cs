using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallingPlanGetDigitPatternListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "digitPatternTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable DigitPatternTable { get; set; }
 }
}
