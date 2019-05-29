using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCommunicationBarringCriteriaModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "name", IsNullable = false)]
    public string Name { get; set; }
    [XmlElement(ElementName = "newName", IsNullable = false)]
    public string NewName { get; set; }
    [XmlElement(ElementName = "description", IsNullable = true)]
    public string Description { get; set; }
    [XmlElement(ElementName = "matchCallType", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.ReplacementCommunicationBarringCallTypeList MatchCallType { get; set; }
    [XmlElement(ElementName = "matchAlternateCallIndicator", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.ReplacementCommunicationBarringAlternateCallIndicatorList MatchAlternateCallIndicator { get; set; }
    [XmlElement(ElementName = "matchVirtualOnNetCallType", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.ReplacementVirtualOnNetCallTypeNameList MatchVirtualOnNetCallType { get; set; }
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
    [XmlElement(ElementName = "matchOtherGETSGets", IsNullable = false)]
    public bool MatchOtherGETSGets { get; set; }
    [XmlElement(ElementName = "matchNotGETSGets", IsNullable = false)]
    public bool MatchNotGETSGets { get; set; }
    [XmlElement(ElementName = "matchGETSANGets", IsNullable = false)]
    public bool MatchGETSANGets { get; set; }
    [XmlElement(ElementName = "matchGETSNTGets", IsNullable = false)]
    public bool MatchGETSNTGets { get; set; }
    [XmlElement(ElementName = "matchGETSFCGets", IsNullable = false)]
    public bool MatchGETSFCGets { get; set; }
    [XmlElement(ElementName = "matchGETSFCANGets", IsNullable = false)]
    public bool MatchGETSFCANGets { get; set; }
    [XmlElement(ElementName = "matchGETSFCNTGets", IsNullable = false)]
    public bool MatchGETSFCNTGets { get; set; }
    [XmlElement(ElementName = "matchLocation", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LocationCriteria MatchLocation { get; set; }
    [XmlElement(ElementName = "matchRoaming", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.RoamingCriteria MatchRoaming { get; set; }
    [XmlElement(ElementName = "timeSchedule", IsNullable = true)]
    public string TimeSchedule { get; set; }
    [XmlElement(ElementName = "holidaySchedule", IsNullable = true)]
    public string HolidaySchedule { get; set; }
    [XmlElement(ElementName = "matchNumberPortabilityStatus", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ReplacementNumberPortabilityStatusList MatchNumberPortabilityStatus { get; set; }
 }
}
