using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCommunicationBarringProfileAddRequest17sp3 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "name", IsNullable = false)]
    public string Name { get; set; }
    [XmlElement(ElementName = "description", IsNullable = false)]
    public string Description { get; set; }
    [XmlElement(ElementName = "originatingDefaultAction", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CommunicationBarringOriginatingAction OriginatingDefaultAction { get; set; }
    [XmlElement(ElementName = "originatingDefaultTreatmentId", IsNullable = false)]
    public string OriginatingDefaultTreatmentId { get; set; }
    [XmlElement(ElementName = "originatingDefaultTransferNumber", IsNullable = false)]
    public string OriginatingDefaultTransferNumber { get; set; }
    [XmlElement(ElementName = "originatingDefaultCallTimeout", IsNullable = false)]
    public int OriginatingDefaultCallTimeout { get; set; }
    [XmlElement(ElementName = "originatingRule", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.CommunicationBarringOriginatingRule> OriginatingRule { get; set; }
    [XmlElement(ElementName = "redirectingDefaultAction", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CommunicationBarringRedirectingAction RedirectingDefaultAction { get; set; }
    [XmlElement(ElementName = "redirectingDefaultCallTimeout", IsNullable = false)]
    public int RedirectingDefaultCallTimeout { get; set; }
    [XmlElement(ElementName = "redirectingRule", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.CommunicationBarringRedirectingRule> RedirectingRule { get; set; }
    [XmlElement(ElementName = "incomingDefaultAction", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CommunicationBarringIncomingAction IncomingDefaultAction { get; set; }
    [XmlElement(ElementName = "incomingDefaultCallTimeout", IsNullable = false)]
    public int IncomingDefaultCallTimeout { get; set; }
    [XmlElement(ElementName = "incomingRule", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.CommunicationBarringIncomingRule> IncomingRule { get; set; }
    [XmlElement(ElementName = "callMeNowDefaultAction", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CommunicationBarringCallMeNowAction CallMeNowDefaultAction { get; set; }
    [XmlElement(ElementName = "callMeNowDefaultCallTimeout", IsNullable = false)]
    public int CallMeNowDefaultCallTimeout { get; set; }
    [XmlElement(ElementName = "callMeNowRule", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.CommunicationBarringCallMeNowRule> CallMeNowRule { get; set; }
 }
}
