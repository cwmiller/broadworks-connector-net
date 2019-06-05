using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCommunicationBarringProfileGetResponse17sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _description;

    [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
    public string Description {
        get => _description;
        set {
            DescriptionSpecified = true;
            _description = value;
        }
    }

    [XmlIgnore]
    public bool DescriptionSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.CommunicationBarringOriginatingAction _originatingDefaultAction;

    [XmlElement(ElementName = "originatingDefaultAction", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CommunicationBarringOriginatingAction OriginatingDefaultAction {
        get => _originatingDefaultAction;
        set {
            OriginatingDefaultActionSpecified = true;
            _originatingDefaultAction = value;
        }
    }

    [XmlIgnore]
    public bool OriginatingDefaultActionSpecified { get; set; }
    private string _originatingDefaultTreatmentId;

    [XmlElement(ElementName = "originatingDefaultTreatmentId", IsNullable = false, Namespace = "")]
    public string OriginatingDefaultTreatmentId {
        get => _originatingDefaultTreatmentId;
        set {
            OriginatingDefaultTreatmentIdSpecified = true;
            _originatingDefaultTreatmentId = value;
        }
    }

    [XmlIgnore]
    public bool OriginatingDefaultTreatmentIdSpecified { get; set; }
    private string _originatingDefaultTransferNumber;

    [XmlElement(ElementName = "originatingDefaultTransferNumber", IsNullable = false, Namespace = "")]
    public string OriginatingDefaultTransferNumber {
        get => _originatingDefaultTransferNumber;
        set {
            OriginatingDefaultTransferNumberSpecified = true;
            _originatingDefaultTransferNumber = value;
        }
    }

    [XmlIgnore]
    public bool OriginatingDefaultTransferNumberSpecified { get; set; }
    private int _originatingDefaultCallTimeout;

    [XmlElement(ElementName = "originatingDefaultCallTimeout", IsNullable = false, Namespace = "")]
    public int OriginatingDefaultCallTimeout {
        get => _originatingDefaultCallTimeout;
        set {
            OriginatingDefaultCallTimeoutSpecified = true;
            _originatingDefaultCallTimeout = value;
        }
    }

    [XmlIgnore]
    public bool OriginatingDefaultCallTimeoutSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.CommunicationBarringOriginatingRule> _originatingRule;

    [XmlElement(ElementName = "originatingRule", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.CommunicationBarringOriginatingRule> OriginatingRule {
        get => _originatingRule;
        set {
            OriginatingRuleSpecified = true;
            _originatingRule = value;
        }
    }

    [XmlIgnore]
    public bool OriginatingRuleSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.CommunicationBarringRedirectingAction _redirectingDefaultAction;

    [XmlElement(ElementName = "redirectingDefaultAction", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CommunicationBarringRedirectingAction RedirectingDefaultAction {
        get => _redirectingDefaultAction;
        set {
            RedirectingDefaultActionSpecified = true;
            _redirectingDefaultAction = value;
        }
    }

    [XmlIgnore]
    public bool RedirectingDefaultActionSpecified { get; set; }
    private int _redirectingDefaultCallTimeout;

    [XmlElement(ElementName = "redirectingDefaultCallTimeout", IsNullable = false, Namespace = "")]
    public int RedirectingDefaultCallTimeout {
        get => _redirectingDefaultCallTimeout;
        set {
            RedirectingDefaultCallTimeoutSpecified = true;
            _redirectingDefaultCallTimeout = value;
        }
    }

    [XmlIgnore]
    public bool RedirectingDefaultCallTimeoutSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.CommunicationBarringRedirectingRule> _redirectingRule;

    [XmlElement(ElementName = "redirectingRule", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.CommunicationBarringRedirectingRule> RedirectingRule {
        get => _redirectingRule;
        set {
            RedirectingRuleSpecified = true;
            _redirectingRule = value;
        }
    }

    [XmlIgnore]
    public bool RedirectingRuleSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.CommunicationBarringIncomingAction _incomingDefaultAction;

    [XmlElement(ElementName = "incomingDefaultAction", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CommunicationBarringIncomingAction IncomingDefaultAction {
        get => _incomingDefaultAction;
        set {
            IncomingDefaultActionSpecified = true;
            _incomingDefaultAction = value;
        }
    }

    [XmlIgnore]
    public bool IncomingDefaultActionSpecified { get; set; }
    private int _incomingDefaultCallTimeout;

    [XmlElement(ElementName = "incomingDefaultCallTimeout", IsNullable = false, Namespace = "")]
    public int IncomingDefaultCallTimeout {
        get => _incomingDefaultCallTimeout;
        set {
            IncomingDefaultCallTimeoutSpecified = true;
            _incomingDefaultCallTimeout = value;
        }
    }

    [XmlIgnore]
    public bool IncomingDefaultCallTimeoutSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.CommunicationBarringIncomingRule> _incomingRule;

    [XmlElement(ElementName = "incomingRule", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.CommunicationBarringIncomingRule> IncomingRule {
        get => _incomingRule;
        set {
            IncomingRuleSpecified = true;
            _incomingRule = value;
        }
    }

    [XmlIgnore]
    public bool IncomingRuleSpecified { get; set; }
}
}
