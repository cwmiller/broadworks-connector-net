using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserBroadWorksMobilityGetResponse21 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "useMobileIdentityCallAnchoring", IsNullable = false)]
    public bool UseMobileIdentityCallAnchoring { get; set; }
    [XmlElement(ElementName = "preventCallsToOwnMobiles", IsNullable = false)]
    public bool PreventCallsToOwnMobiles { get; set; }
    [XmlElement(ElementName = "mobileIdentity", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.BroadWorksMobilityUserMobileIdentityEntry> MobileIdentity { get; set; }
    [XmlElement(ElementName = "profileIdentityDevicesToRing", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.BroadWorksMobilityPhoneToRing ProfileIdentityDevicesToRing { get; set; }
    [XmlElement(ElementName = "profileIdentityIncludeSharedCallAppearance", IsNullable = false)]
    public bool ProfileIdentityIncludeSharedCallAppearance { get; set; }
    [XmlElement(ElementName = "profileIdentityIncludeBroadworksAnywhere", IsNullable = false)]
    public bool ProfileIdentityIncludeBroadworksAnywhere { get; set; }
    [XmlElement(ElementName = "profileIdentityIncludeExecutiveAssistant", IsNullable = false)]
    public bool ProfileIdentityIncludeExecutiveAssistant { get; set; }
    [XmlElement(ElementName = "profileIdentityMobileNumberAlerted", IsNullable = false)]
    public List<string> ProfileIdentityMobileNumberAlerted { get; set; }
 }
}
