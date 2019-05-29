using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserSharedCallAppearanceModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "alertAllAppearancesForClickToDialCalls", IsNullable = false)]
    public bool AlertAllAppearancesForClickToDialCalls { get; set; }
    [XmlElement(ElementName = "alertAllAppearancesForGroupPagingCalls", IsNullable = false)]
    public bool AlertAllAppearancesForGroupPagingCalls { get; set; }
    [XmlElement(ElementName = "allowSCACallRetrieve", IsNullable = false)]
    public bool AllowSCACallRetrieve { get; set; }
    [XmlElement(ElementName = "multipleCallArrangementIsActive", IsNullable = false)]
    public bool MultipleCallArrangementIsActive { get; set; }
    [XmlElement(ElementName = "allowBridgingBetweenLocations", IsNullable = false)]
    public bool AllowBridgingBetweenLocations { get; set; }
    [XmlElement(ElementName = "bridgeWarningTone", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SharedCallAppearanceBridgeWarningTone BridgeWarningTone { get; set; }
    [XmlElement(ElementName = "enableCallParkNotification", IsNullable = false)]
    public bool EnableCallParkNotification { get; set; }
    [XmlElement(ElementName = "useUserPrimaryWithAlternateCallsSetting", IsNullable = false)]
    public bool UseUserPrimaryWithAlternateCallsSetting { get; set; }
    [XmlElement(ElementName = "allowSimultaneousPrimaryAndAlternateCalls", IsNullable = false)]
    public bool AllowSimultaneousPrimaryAndAlternateCalls { get; set; }
    [XmlElement(ElementName = "restrictCallRetrieveOfPrimaryCall", IsNullable = false)]
    public bool RestrictCallRetrieveOfPrimaryCall { get; set; }
    [XmlElement(ElementName = "restrictCallBridgingOfPrimaryCall", IsNullable = false)]
    public bool RestrictCallBridgingOfPrimaryCall { get; set; }
 }
}
