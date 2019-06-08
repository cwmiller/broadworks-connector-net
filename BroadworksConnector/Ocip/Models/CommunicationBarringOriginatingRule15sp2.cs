using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CommunicationBarringOriginatingRule15sp2 
{
    private string _criteria;

    [XmlElement(ElementName = "criteria", IsNullable = false, Namespace = "")]
    public string Criteria {
        get => _criteria;
        set {
            CriteriaSpecified = true;
            _criteria = value;
        }
    }

    [XmlIgnore]
    public bool CriteriaSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CommunicationBarringOriginatingAction15sp2 _action;

    [XmlElement(ElementName = "action", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CommunicationBarringOriginatingAction15sp2 Action {
        get => _action;
        set {
            ActionSpecified = true;
            _action = value;
        }
    }

    [XmlIgnore]
    public bool ActionSpecified { get; set; }
    private string _treatmentId;

    [XmlElement(ElementName = "treatmentId", IsNullable = true, Namespace = "")]
    public string TreatmentId {
        get => _treatmentId;
        set {
            TreatmentIdSpecified = true;
            _treatmentId = value;
        }
    }

    [XmlIgnore]
    public bool TreatmentIdSpecified { get; set; }
    private string _transferNumber;

    [XmlElement(ElementName = "transferNumber", IsNullable = true, Namespace = "")]
    public string TransferNumber {
        get => _transferNumber;
        set {
            TransferNumberSpecified = true;
            _transferNumber = value;
        }
    }

    [XmlIgnore]
    public bool TransferNumberSpecified { get; set; }
}
}
