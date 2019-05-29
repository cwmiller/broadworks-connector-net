using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserBroadWorksMobilityModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "phonesToRing", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.BroadWorksMobilityPhoneToRing PhonesToRing { get; set; }
    [XmlElement(ElementName = "mobilePhoneNumber", IsNullable = true)]
    public string MobilePhoneNumber { get; set; }
    [XmlElement(ElementName = "alertClickToDialCalls", IsNullable = false)]
    public bool AlertClickToDialCalls { get; set; }
    [XmlElement(ElementName = "alertGroupPagingCalls", IsNullable = false)]
    public bool AlertGroupPagingCalls { get; set; }
    [XmlElement(ElementName = "enableDiversionInhibitor", IsNullable = false)]
    public bool EnableDiversionInhibitor { get; set; }
    [XmlElement(ElementName = "requireAnswerConfirmation", IsNullable = false)]
    public bool RequireAnswerConfirmation { get; set; }
    [XmlElement(ElementName = "broadworksCallControl", IsNullable = false)]
    public bool BroadworksCallControl { get; set; }
    [XmlElement(ElementName = "useSettingLevel", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.BroadWorksMobilityUserSettingLevel UseSettingLevel { get; set; }
    [XmlElement(ElementName = "denyCallOriginations", IsNullable = false)]
    public bool DenyCallOriginations { get; set; }
    [XmlElement(ElementName = "denyCallTerminations", IsNullable = false)]
    public bool DenyCallTerminations { get; set; }
 }
}
