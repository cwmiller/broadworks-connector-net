using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserBroadWorksAnywhereAddPhoneNumberRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "phoneNumber", IsNullable = false)]
    public string PhoneNumber { get; set; }
    [XmlElement(ElementName = "description", IsNullable = false)]
    public string Description { get; set; }
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "outboundAlternateNumber", IsNullable = false)]
    public string OutboundAlternateNumber { get; set; }
    [XmlElement(ElementName = "broadworksCallControl", IsNullable = false)]
    public bool BroadworksCallControl { get; set; }
    [XmlElement(ElementName = "useDiversionInhibitor", IsNullable = false)]
    public bool UseDiversionInhibitor { get; set; }
    [XmlElement(ElementName = "answerConfirmationRequired", IsNullable = false)]
    public bool AnswerConfirmationRequired { get; set; }
 }
}
