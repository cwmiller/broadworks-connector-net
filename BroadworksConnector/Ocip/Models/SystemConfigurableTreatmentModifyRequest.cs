using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemConfigurableTreatmentModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "treatmentId", IsNullable = false)]
    public string TreatmentId { get; set; }
    [XmlElement(ElementName = "chargeIndicator", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ChargeIndicator ChargeIndicator { get; set; }
    [XmlElement(ElementName = "description", IsNullable = true)]
    public string Description { get; set; }
    [XmlElement(ElementName = "accessSIPStatusCode", IsNullable = true)]
    public int? AccessSIPStatusCode { get; set; }
    [XmlElement(ElementName = "accessSIPStatusMessage", IsNullable = true)]
    public string AccessSIPStatusMessage { get; set; }
    [XmlElement(ElementName = "networkSIPStatusCode", IsNullable = true)]
    public int? NetworkSIPStatusCode { get; set; }
    [XmlElement(ElementName = "networkSIPStatusMessage", IsNullable = true)]
    public string NetworkSIPStatusMessage { get; set; }
    [XmlElement(ElementName = "q850CauseValue", IsNullable = true)]
    public int? Q850CauseValue { get; set; }
    [XmlElement(ElementName = "q850Text", IsNullable = true)]
    public string Q850Text { get; set; }
    [XmlElement(ElementName = "accessTreatmentAudioFile", IsNullable = true)]
    public string AccessTreatmentAudioFile { get; set; }
    [XmlElement(ElementName = "accessTreatmentVideoFile", IsNullable = true)]
    public string AccessTreatmentVideoFile { get; set; }
    [XmlElement(ElementName = "networkTreatmentAudioFile", IsNullable = true)]
    public string NetworkTreatmentAudioFile { get; set; }
    [XmlElement(ElementName = "networkTreatmentVideoFile", IsNullable = true)]
    public string NetworkTreatmentVideoFile { get; set; }
    [XmlElement(ElementName = "cdrTerminationCause", IsNullable = true)]
    public string CdrTerminationCause { get; set; }
    [XmlElement(ElementName = "routeAdvance", IsNullable = false)]
    public bool RouteAdvance { get; set; }
    [XmlElement(ElementName = "internalReleaseCause", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.InternalReleaseCause16? InternalReleaseCause { get; set; }
    [XmlElement(ElementName = "accessSendReasonHeader", IsNullable = false)]
    public bool AccessSendReasonHeader { get; set; }
    [XmlElement(ElementName = "networkSendReasonHeader", IsNullable = false)]
    public bool NetworkSendReasonHeader { get; set; }
 }
}
