using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCommunicationBarringProfileGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
    private BroadWorksConnector.Ocip.Models.CommunicationBarringOriginatingAction15sp2 _originatingDefaultAction;

    [XmlElement(ElementName = "originatingDefaultAction", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CommunicationBarringOriginatingAction15sp2 OriginatingDefaultAction {
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
    private List<BroadWorksConnector.Ocip.Models.CommunicationBarringOriginatingRule15sp2> _originatingRule;

    [XmlElement(ElementName = "originatingRule", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.CommunicationBarringOriginatingRule15sp2> OriginatingRule {
        get => _originatingRule;
        set {
            OriginatingRuleSpecified = true;
            _originatingRule = value;
        }
    }

    [XmlIgnore]
    public bool OriginatingRuleSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CommunicationBarringRedirectingAction15sp2 _redirectingDefaultAction;

    [XmlElement(ElementName = "redirectingDefaultAction", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CommunicationBarringRedirectingAction15sp2 RedirectingDefaultAction {
        get => _redirectingDefaultAction;
        set {
            RedirectingDefaultActionSpecified = true;
            _redirectingDefaultAction = value;
        }
    }

    [XmlIgnore]
    public bool RedirectingDefaultActionSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.CommunicationBarringRedirectingRule15sp2> _redirectingRule;

    [XmlElement(ElementName = "redirectingRule", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.CommunicationBarringRedirectingRule15sp2> RedirectingRule {
        get => _redirectingRule;
        set {
            RedirectingRuleSpecified = true;
            _redirectingRule = value;
        }
    }

    [XmlIgnore]
    public bool RedirectingRuleSpecified { get; set; }
}
}
