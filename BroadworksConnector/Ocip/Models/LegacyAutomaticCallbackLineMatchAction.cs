using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Legacy Automatic Callback line type match action.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum LegacyAutomaticCallbackLineMatchAction    {
            [XmlEnum(Name = "Accept")]
        Accept,
            [XmlEnum(Name = "Deny")]
        Deny,
     }
}
