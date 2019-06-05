using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserBroadWorksAnywhereGetPhoneNumberResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
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
    private string _outboundAlternateNumber;

    [XmlElement(ElementName = "outboundAlternateNumber", IsNullable = false, Namespace = "")]
    public string OutboundAlternateNumber {
        get => _outboundAlternateNumber;
        set {
            OutboundAlternateNumberSpecified = true;
            _outboundAlternateNumber = value;
        }
    }

    [XmlIgnore]
    public bool OutboundAlternateNumberSpecified { get; set; }
    private bool _isActive;

    [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
    public bool IsActive {
        get => _isActive;
        set {
            IsActiveSpecified = true;
            _isActive = value;
        }
    }

    [XmlIgnore]
    public bool IsActiveSpecified { get; set; }
    private bool _broadworksCallControl;

    [XmlElement(ElementName = "broadworksCallControl", IsNullable = false, Namespace = "")]
    public bool BroadworksCallControl {
        get => _broadworksCallControl;
        set {
            BroadworksCallControlSpecified = true;
            _broadworksCallControl = value;
        }
    }

    [XmlIgnore]
    public bool BroadworksCallControlSpecified { get; set; }
    private bool _useDiversionInhibitor;

    [XmlElement(ElementName = "useDiversionInhibitor", IsNullable = false, Namespace = "")]
    public bool UseDiversionInhibitor {
        get => _useDiversionInhibitor;
        set {
            UseDiversionInhibitorSpecified = true;
            _useDiversionInhibitor = value;
        }
    }

    [XmlIgnore]
    public bool UseDiversionInhibitorSpecified { get; set; }
    private bool _answerConfirmationRequired;

    [XmlElement(ElementName = "answerConfirmationRequired", IsNullable = false, Namespace = "")]
    public bool AnswerConfirmationRequired {
        get => _answerConfirmationRequired;
        set {
            AnswerConfirmationRequiredSpecified = true;
            _answerConfirmationRequired = value;
        }
    }

    [XmlIgnore]
    public bool AnswerConfirmationRequiredSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.C.OCITable _criteriaTable;

    [XmlElement(ElementName = "criteriaTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable CriteriaTable {
        get => _criteriaTable;
        set {
            CriteriaTableSpecified = true;
            _criteriaTable = value;
        }
    }

    [XmlIgnore]
    public bool CriteriaTableSpecified { get; set; }
}
}
