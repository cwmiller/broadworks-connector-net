using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderCommunicationBarringProfileModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "name", IsNullable = false)]
    public string Name { get; set; }
    [XmlElement(ElementName = "newName", IsNullable = false)]
    public string NewName { get; set; }
    [XmlElement(ElementName = "description", IsNullable = true)]
    public string Description { get; set; }
    [XmlElement(ElementName = "originatingDefaultAction", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CommunicationBarringOriginatingAction OriginatingDefaultAction { get; set; }
    [XmlElement(ElementName = "originatingDefaultTreatmentId", IsNullable = true)]
    public string OriginatingDefaultTreatmentId { get; set; }
    [XmlElement(ElementName = "originatingDefaultTransferNumber", IsNullable = true)]
    public string OriginatingDefaultTransferNumber { get; set; }
    [XmlElement(ElementName = "originatingDefaultCallTimeout", IsNullable = true)]
    public int? OriginatingDefaultCallTimeout { get; set; }
    [XmlElement(ElementName = "originatingRule", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.ServiceProviderReplacementCommunicationBarringHierarchicalOriginatingRuleList OriginatingRule { get; set; }
    [XmlElement(ElementName = "redirectingDefaultAction", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CommunicationBarringRedirectingAction RedirectingDefaultAction { get; set; }
    [XmlElement(ElementName = "redirectingDefaultCallTimeout", IsNullable = true)]
    public int? RedirectingDefaultCallTimeout { get; set; }
    [XmlElement(ElementName = "redirectingRule", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.ServiceProviderReplacementCommunicationBarringHierarchicalRedirectingRuleList RedirectingRule { get; set; }
    [XmlElement(ElementName = "callMeNowDefaultAction", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CommunicationBarringCallMeNowAction CallMeNowDefaultAction { get; set; }
    [XmlElement(ElementName = "callMeNowDefaultCallTimeout", IsNullable = true)]
    public int? CallMeNowDefaultCallTimeout { get; set; }
    [XmlElement(ElementName = "callMeNowRule", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.ServiceProviderReplacementCommunicationBarringHierarchicalCallMeNowRuleList CallMeNowRule { get; set; }
    [XmlElement(ElementName = "incomingDefaultAction", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CommunicationBarringIncomingAction IncomingDefaultAction { get; set; }
    [XmlElement(ElementName = "incomingDefaultCallTimeout", IsNullable = true)]
    public int? IncomingDefaultCallTimeout { get; set; }
    [XmlElement(ElementName = "incomingRule", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.ReplacementCommunicationBarringIncomingRuleList19sp1 IncomingRule { get; set; }
    [XmlElement(ElementName = "becomeDefault", IsNullable = false)]
    public bool BecomeDefault { get; set; }
    [XmlElement(ElementName = "applyToAttendedCallTransfers", IsNullable = false)]
    public bool ApplyToAttendedCallTransfers { get; set; }
 }
}
