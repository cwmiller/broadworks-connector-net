using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserBroadWorksMobilityModifyRequest21 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "useMobileIdentityCallAnchoring", IsNullable = false)]
    public bool UseMobileIdentityCallAnchoring { get; set; }
    [XmlElement(ElementName = "preventCallsToOwnMobiles", IsNullable = false)]
    public bool PreventCallsToOwnMobiles { get; set; }
    [XmlElement(ElementName = "mobileIdentity", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.BroadWorksMobilityUserMobileIdentityModifyEntry> MobileIdentity { get; set; }
    [XmlElement(ElementName = "profileIdentityDevicesToRing", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.BroadWorksMobilityPhoneToRing ProfileIdentityDevicesToRing { get; set; }
    [XmlElement(ElementName = "profileIdentityIncludeSharedCallAppearance", IsNullable = false)]
    public bool ProfileIdentityIncludeSharedCallAppearance { get; set; }
    [XmlElement(ElementName = "profileIdentityIncludeBroadworksAnywhere", IsNullable = false)]
    public bool ProfileIdentityIncludeBroadworksAnywhere { get; set; }
    [XmlElement(ElementName = "profileIdentityIncludeExecutiveAssistant", IsNullable = false)]
    public bool ProfileIdentityIncludeExecutiveAssistant { get; set; }
    [XmlElement(ElementName = "profileIdentityMobilityNumbersAlerted", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.BroadWorksMobilityAlertingMobileNumberReplacementList ProfileIdentityMobilityNumbersAlerted { get; set; }
 }
}
