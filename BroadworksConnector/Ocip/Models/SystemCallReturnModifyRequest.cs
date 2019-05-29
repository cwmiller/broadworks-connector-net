using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallReturnModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "twoLevelActivation", IsNullable = false)]
    public bool TwoLevelActivation { get; set; }
    [XmlElement(ElementName = "provideDate", IsNullable = false)]
    public bool ProvideDate { get; set; }
    [XmlElement(ElementName = "lastUnansweredCallOnly", IsNullable = false)]
    public bool LastUnansweredCallOnly { get; set; }
    [XmlElement(ElementName = "confirmationKey", IsNullable = true)]
    public string ConfirmationKey { get; set; }
    [XmlElement(ElementName = "allowRestrictedNumber", IsNullable = false)]
    public bool AllowRestrictedNumber { get; set; }
    [XmlElement(ElementName = "deleteNumberAfterAnsweredCallReturn", IsNullable = false)]
    public bool DeleteNumberAfterAnsweredCallReturn { get; set; }
 }
}
