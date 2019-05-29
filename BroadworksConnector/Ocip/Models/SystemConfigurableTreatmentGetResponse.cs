using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemConfigurableTreatmentGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "description", IsNullable = false)]
    public string Description { get; set; }
    [XmlElement(ElementName = "chargeIndicator", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ChargeIndicator ChargeIndicator { get; set; }
    [XmlElement(ElementName = "accessSIPStatusCode", IsNullable = false)]
    public int AccessSIPStatusCode { get; set; }
    [XmlElement(ElementName = "accessSIPStatusMessage", IsNullable = false)]
    public string AccessSIPStatusMessage { get; set; }
    [XmlElement(ElementName = "networkSIPStatusCode", IsNullable = false)]
    public int NetworkSIPStatusCode { get; set; }
    [XmlElement(ElementName = "networkSIPStatusMessage", IsNullable = false)]
    public string NetworkSIPStatusMessage { get; set; }
    [XmlElement(ElementName = "q850CauseValue", IsNullable = false)]
    public int Q850CauseValue { get; set; }
    [XmlElement(ElementName = "q850Text", IsNullable = false)]
    public string Q850Text { get; set; }
    [XmlElement(ElementName = "accessTreatmentAudioFile", IsNullable = false)]
    public string AccessTreatmentAudioFile { get; set; }
    [XmlElement(ElementName = "accessTreatmentVideoFile", IsNullable = false)]
    public string AccessTreatmentVideoFile { get; set; }
    [XmlElement(ElementName = "networkTreatmentAudioFile", IsNullable = false)]
    public string NetworkTreatmentAudioFile { get; set; }
    [XmlElement(ElementName = "networkTreatmentVideoFile", IsNullable = false)]
    public string NetworkTreatmentVideoFile { get; set; }
    [XmlElement(ElementName = "cdrTerminationCause", IsNullable = false)]
    public string CdrTerminationCause { get; set; }
    [XmlElement(ElementName = "routeAdvance", IsNullable = false)]
    public bool RouteAdvance { get; set; }
    [XmlElement(ElementName = "internalReleaseCause", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.InternalReleaseCause InternalReleaseCause { get; set; }
    [XmlElement(ElementName = "accessSendReasonHeader", IsNullable = false)]
    public bool AccessSendReasonHeader { get; set; }
    [XmlElement(ElementName = "networkSendReasonHeader", IsNullable = false)]
    public bool NetworkSendReasonHeader { get; set; }
 }
}
