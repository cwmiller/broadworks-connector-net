using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupDialableCallerIDCriteriaModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "name", IsNullable = false)]
    public string Name { get; set; }
    [XmlElement(ElementName = "newName", IsNullable = false)]
    public string NewName { get; set; }
    [XmlElement(ElementName = "description", IsNullable = true)]
    public string Description { get; set; }
    [XmlElement(ElementName = "prefixDigits", IsNullable = true)]
    public string PrefixDigits { get; set; }
    [XmlElement(ElementName = "matchCallType", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.ReplacementCommunicationBarringCallTypeList MatchCallType { get; set; }
    [XmlElement(ElementName = "matchAlternateCallIndicator", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.ReplacementCommunicationBarringAlternateCallIndicatorList MatchAlternateCallIndicator { get; set; }
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
