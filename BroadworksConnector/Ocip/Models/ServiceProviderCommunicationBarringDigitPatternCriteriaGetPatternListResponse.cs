using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderCommunicationBarringDigitPatternCriteriaGetPatternListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "matchDigitPattern", IsNullable = false)]
    public List<string> MatchDigitPattern { get; set; }
 }
}
