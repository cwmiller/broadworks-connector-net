using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SequentialRingLocation14sp4 
{
    [XmlElement(ElementName = "phoneNumber", IsNullable = false)]
    public string PhoneNumber { get; set; }
    [XmlElement(ElementName = "numberOfRings", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SequentialRingNumberOfRings NumberOfRings { get; set; }
    [XmlElement(ElementName = "answerConfirmationRequired", IsNullable = false)]
    public bool AnswerConfirmationRequired { get; set; }
 }
}
