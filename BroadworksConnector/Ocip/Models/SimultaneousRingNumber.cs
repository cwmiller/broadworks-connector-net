using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SimultaneousRingNumber 
{
    [XmlElement(ElementName = "phoneNumber", IsNullable = false)]
    public string PhoneNumber { get; set; }
    [XmlElement(ElementName = "answerConfirmationRequired", IsNullable = false)]
    public bool AnswerConfirmationRequired { get; set; }
 }
}
