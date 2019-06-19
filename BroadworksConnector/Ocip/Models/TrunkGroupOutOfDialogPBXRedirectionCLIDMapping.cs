using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Parameter to control whether to enable Trunking OOD PBX Redirection CLID mapping.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum TrunkGroupOutOfDialogPBXRedirectionCLIDMapping
    {
        [XmlEnum(Name = "Disabled")]
        Disabled,
        [XmlEnum(Name = "Enabled And Ignore Policies")]
        EnabledAndIgnorePolicies,
        [XmlEnum(Name = "Enabled And Apply Policies")]
        EnabledAndApplyPolicies,
    }
}
