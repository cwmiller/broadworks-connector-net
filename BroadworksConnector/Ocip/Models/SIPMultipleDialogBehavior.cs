using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Choices
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum SIPMultipleDialogBehavior
    {
        [XmlEnum(Name = "Multiple Dialogs")]
        MultipleDialogs,
        [XmlEnum(Name = "Multiple Dialogs With Error Correction")]
        MultipleDialogsWithErrorCorrection,
    }
}
