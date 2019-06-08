using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum SIPSingleDialogBehavior{
    [XmlEnum(Name = "Single Dialog")]
    SingleDialog,
    [XmlEnum(Name = "Single Dialog With UPDATE")]
    SingleDialogWithUPDATE,
    [XmlEnum(Name = "Single Dialog With UPDATE If Allowed")]
    SingleDialogWithUPDATEIfAllowed,
 }
}
