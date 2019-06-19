using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Choices for Forking Support Method
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum SIPForkingSupport
    {
        [XmlEnum(Name = "Single Dialog")]
        SingleDialog,
        [XmlEnum(Name = "Single Dialog With UPDATE")]
        SingleDialogWithUPDATE,
        [XmlEnum(Name = "Multiple Dialogs With Error Correction")]
        MultipleDialogsWithErrorCorrection,
        [XmlEnum(Name = "Multiple Dialogs")]
        MultipleDialogs,
        [XmlEnum(Name = "Single Dialog With UPDATE If Allowed")]
        SingleDialogWithUPDATEIfAllowed,
    }
}
