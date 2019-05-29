using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ProfileAndServiceSharedCallAppearanceInfo 
{
    [XmlElement(ElementName = "alertAllAppearancesForClickToDialCalls", IsNullable = false)]
    public bool AlertAllAppearancesForClickToDialCalls { get; set; }
    [XmlElement(ElementName = "alertAllAppearancesForGroupPagingCalls", IsNullable = false)]
    public bool AlertAllAppearancesForGroupPagingCalls { get; set; }
    [XmlElement(ElementName = "maxAppearances", IsNullable = false)]
    public int MaxAppearances { get; set; }
    [XmlElement(ElementName = "allowSCACallRetrieve", IsNullable = false)]
    public bool AllowSCACallRetrieve { get; set; }
    [XmlElement(ElementName = "enableMultipleCallArrangement", IsNullable = false)]
    public bool EnableMultipleCallArrangement { get; set; }
    [XmlElement(ElementName = "multipleCallArrangementIsActive", IsNullable = false)]
    public bool MultipleCallArrangementIsActive { get; set; }
    [XmlElement(ElementName = "endpointTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable EndpointTable { get; set; }
    [XmlElement(ElementName = "allowBridgingBetweenLocations", IsNullable = false)]
    public bool AllowBridgingBetweenLocations { get; set; }
    [XmlElement(ElementName = "bridgeWarningTone", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SharedCallAppearanceBridgeWarningTone BridgeWarningTone { get; set; }
    [XmlElement(ElementName = "enableCallParkNotification", IsNullable = false)]
    public bool EnableCallParkNotification { get; set; }
    [XmlElement(ElementName = "useUserPrimaryWithAlternateCallsSetting", IsNullable = false)]
    public bool UseUserPrimaryWithAlternateCallsSetting { get; set; }
    [XmlElement(ElementName = "allowSimultaneousPrimaryAndAlternate", IsNullable = false)]
    public bool AllowSimultaneousPrimaryAndAlternate { get; set; }
    [XmlElement(ElementName = "restrictCallRetrieveOfPrimary", IsNullable = false)]
    public bool RestrictCallRetrieveOfPrimary { get; set; }
    [XmlElement(ElementName = "restrictCallBridgingOfPrimary", IsNullable = false)]
    public bool RestrictCallBridgingOfPrimary { get; set; }
 }
}
