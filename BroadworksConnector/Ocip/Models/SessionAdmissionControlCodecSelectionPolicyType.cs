using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Session Admission Control codec selection policy.
    /// Determines which codec is selected from the SDP offer when using SAC weight count.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum SessionAdmissionControlCodecSelectionPolicyType    {
            [XmlEnum(Name = "Highest Weight")]
        HighestWeight,
            [XmlEnum(Name = "Preferred Codec")]
        PreferredCodec,
     }
}
