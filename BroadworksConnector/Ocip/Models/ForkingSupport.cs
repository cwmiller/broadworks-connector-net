using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Choices for Forking Dialog Support Method
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum ForkingSupport    {
            [XmlEnum(Name = "Single Dialog")]
        SingleDialog,
            [XmlEnum(Name = "Multiple Dialogs")]
        MultipleDialogs,
     }
}
