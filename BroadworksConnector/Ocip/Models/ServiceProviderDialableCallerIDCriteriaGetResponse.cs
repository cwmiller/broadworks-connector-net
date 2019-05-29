using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderDialableCallerIDCriteriaGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "description", IsNullable = false)]
    public string Description { get; set; }
    [XmlElement(ElementName = "prefixDigits", IsNullable = false)]
    public string PrefixDigits { get; set; }
    [XmlElement(ElementName = "matchCallType", IsNullable = false)]
    public List<string> MatchCallType { get; set; }
    [XmlElement(ElementName = "matchAlternateCallIndicator", IsNullable = false)]
    public List<string> MatchAlternateCallIndicator { get; set; }
    [XmlElement(ElementName = "matchLocalCategory", IsNullable = false)]
    public bool MatchLocalCategory { get; set; }
    [XmlElement(ElementName = "matchNationalCategory", IsNullable = false)]
    public bool MatchNationalCategory { get; set; }
    [XmlElement(ElementName = "matchInterlataCategory", IsNullable = false)]
    public bool MatchInterlataCategory { get; set; }
    [XmlElement(ElementName = "matchIntralataCategory", IsNullable = false)]
    public bool MatchIntralataCategory { get; set; }
    [XmlElement(ElementName = "matchInternationalCategory", IsNullable = false)]
    public bool MatchInternationalCategory { get; set; }
    [XmlElement(ElementName = "matchPrivateCategory", IsNullable = false)]
    public bool MatchPrivateCategory { get; set; }
    [XmlElement(ElementName = "matchEmergencyCategory", IsNullable = false)]
    public bool MatchEmergencyCategory { get; set; }
    [XmlElement(ElementName = "matchOtherCategory", IsNullable = false)]
    public bool MatchOtherCategory { get; set; }
 }
}
