using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCommunicationBarringCriteriaAddRequest17 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "name", IsNullable = false)]
    public string Name { get; set; }
    [XmlElement(ElementName = "description", IsNullable = false)]
    public string Description { get; set; }
    [XmlElement(ElementName = "matchCallType", IsNullable = false)]
    public List<string> MatchCallType { get; set; }
    [XmlElement(ElementName = "matchAlternateCallIndicator", IsNullable = false)]
    public List<string> MatchAlternateCallIndicator { get; set; }
    [XmlElement(ElementName = "matchVirtualOnNetCallType", IsNullable = false)]
    public List<string> MatchVirtualOnNetCallType { get; set; }
    [XmlElement(ElementName = "matchPublicNetwork", IsNullable = false)]
    public bool MatchPublicNetwork { get; set; }
    [XmlElement(ElementName = "matchPrivateNetwork", IsNullable = false)]
    public bool MatchPrivateNetwork { get; set; }
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
    [XmlElement(ElementName = "matchInterNetwork", IsNullable = false)]
    public bool MatchInterNetwork { get; set; }
    [XmlElement(ElementName = "matchInterHostingNE", IsNullable = false)]
    public bool MatchInterHostingNE { get; set; }
    [XmlElement(ElementName = "matchInterAS", IsNullable = false)]
    public bool MatchInterAS { get; set; }
    [XmlElement(ElementName = "matchIntraAS", IsNullable = false)]
    public bool MatchIntraAS { get; set; }
    [XmlElement(ElementName = "matchChargeCalls", IsNullable = false)]
    public bool MatchChargeCalls { get; set; }
    [XmlElement(ElementName = "matchNoChargeCalls", IsNullable = false)]
    public bool MatchNoChargeCalls { get; set; }
    [XmlElement(ElementName = "matchGroupCalls", IsNullable = false)]
    public bool MatchGroupCalls { get; set; }
    [XmlElement(ElementName = "matchEnterpriseCalls", IsNullable = false)]
    public bool MatchEnterpriseCalls { get; set; }
    [XmlElement(ElementName = "matchNetworkCalls", IsNullable = false)]
    public bool MatchNetworkCalls { get; set; }
    [XmlElement(ElementName = "matchNetworkURLCalls", IsNullable = false)]
    public bool MatchNetworkURLCalls { get; set; }
    [XmlElement(ElementName = "matchRepairCalls", IsNullable = false)]
    public bool MatchRepairCalls { get; set; }
    [XmlElement(ElementName = "matchEmergencyCalls", IsNullable = false)]
    public bool MatchEmergencyCalls { get; set; }
    [XmlElement(ElementName = "matchInternalCalls", IsNullable = false)]
    public bool MatchInternalCalls { get; set; }
    [XmlElement(ElementName = "matchLocation", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LocationCriteria MatchLocation { get; set; }
    [XmlElement(ElementName = "matchRoaming", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.RoamingCriteria MatchRoaming { get; set; }
    [XmlElement(ElementName = "timeSchedule", IsNullable = false)]
    public string TimeSchedule { get; set; }
    [XmlElement(ElementName = "holidaySchedule", IsNullable = false)]
    public string HolidaySchedule { get; set; }
    [XmlElement(ElementName = "matchNumberPortabilityStatus", IsNullable = false)]
    public List<string> MatchNumberPortabilityStatus { get; set; }
 }
}
