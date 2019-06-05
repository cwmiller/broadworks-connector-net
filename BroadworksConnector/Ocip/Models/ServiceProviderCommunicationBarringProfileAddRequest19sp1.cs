using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderCommunicationBarringProfileAddRequest19sp1 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceProviderId;

    [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
    public string ServiceProviderId {
        get => _serviceProviderId;
        set {
            ServiceProviderIdSpecified = true;
            _serviceProviderId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderIdSpecified { get; set; }
    private string _name;

    [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
    public string Name {
        get => _name;
        set {
            NameSpecified = true;
            _name = value;
        }
    }

    [XmlIgnore]
    public bool NameSpecified { get; set; }
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
    private List<BroadworksConnector.Ocip.Models.ServiceProviderCommunicationBarringHierarchicalOriginatingRule> _originatingRule;

    [XmlElement(ElementName = "originatingRule", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.ServiceProviderCommunicationBarringHierarchicalOriginatingRule> OriginatingRule {
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
    private List<BroadworksConnector.Ocip.Models.ServiceProviderCommunicationBarringHierarchicalRedirectingRule> _redirectingRule;

    [XmlElement(ElementName = "redirectingRule", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.ServiceProviderCommunicationBarringHierarchicalRedirectingRule> RedirectingRule {
        get => _redirectingRule;
        set {
            RedirectingRuleSpecified = true;
            _redirectingRule = value;
        }
    }

    [XmlIgnore]
    public bool RedirectingRuleSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.CommunicationBarringCallMeNowAction _callMeNowDefaultAction;

    [XmlElement(ElementName = "callMeNowDefaultAction", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CommunicationBarringCallMeNowAction CallMeNowDefaultAction {
        get => _callMeNowDefaultAction;
        set {
            CallMeNowDefaultActionSpecified = true;
            _callMeNowDefaultAction = value;
        }
    }

    [XmlIgnore]
    public bool CallMeNowDefaultActionSpecified { get; set; }
    private int _callMeNowDefaultCallTimeout;

    [XmlElement(ElementName = "callMeNowDefaultCallTimeout", IsNullable = false, Namespace = "")]
    public int CallMeNowDefaultCallTimeout {
        get => _callMeNowDefaultCallTimeout;
        set {
            CallMeNowDefaultCallTimeoutSpecified = true;
            _callMeNowDefaultCallTimeout = value;
        }
    }

    [XmlIgnore]
    public bool CallMeNowDefaultCallTimeoutSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.ServiceProviderCommunicationBarringHierarchicalCallMeNowRule> _callMeNowRule;

    [XmlElement(ElementName = "callMeNowRule", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.ServiceProviderCommunicationBarringHierarchicalCallMeNowRule> CallMeNowRule {
        get => _callMeNowRule;
        set {
            CallMeNowRuleSpecified = true;
            _callMeNowRule = value;
        }
    }

    [XmlIgnore]
    public bool CallMeNowRuleSpecified { get; set; }
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
    private List<BroadworksConnector.Ocip.Models.CommunicationBarringIncomingRule19sp1> _incomingRule;

    [XmlElement(ElementName = "incomingRule", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.CommunicationBarringIncomingRule19sp1> IncomingRule {
        get => _incomingRule;
        set {
            IncomingRuleSpecified = true;
            _incomingRule = value;
        }
    }

    [XmlIgnore]
    public bool IncomingRuleSpecified { get; set; }
    private bool _becomeDefault;

    [XmlElement(ElementName = "becomeDefault", IsNullable = false, Namespace = "")]
    public bool BecomeDefault {
        get => _becomeDefault;
        set {
            BecomeDefaultSpecified = true;
            _becomeDefault = value;
        }
    }

    [XmlIgnore]
    public bool BecomeDefaultSpecified { get; set; }
    private bool _applyToAttendedCallTransfers;

    [XmlElement(ElementName = "applyToAttendedCallTransfers", IsNullable = false, Namespace = "")]
    public bool ApplyToAttendedCallTransfers {
        get => _applyToAttendedCallTransfers;
        set {
            ApplyToAttendedCallTransfersSpecified = true;
            _applyToAttendedCallTransfers = value;
        }
    }

    [XmlIgnore]
    public bool ApplyToAttendedCallTransfersSpecified { get; set; }
}
}
