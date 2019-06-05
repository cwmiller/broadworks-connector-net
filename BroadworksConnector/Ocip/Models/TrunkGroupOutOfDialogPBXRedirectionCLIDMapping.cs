using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum TrunkGroupOutOfDialogPBXRedirectionCLIDMapping{
    [XmlEnum(Name = "Disabled")]
    Disabled,
    [XmlEnum(Name = "Enabled And Ignore Policies")]
    EnabledAndIgnorePolicies,
    [XmlEnum(Name = "Enabled And Apply Policies")]
    EnabledAndApplyPolicies,
 }
}
