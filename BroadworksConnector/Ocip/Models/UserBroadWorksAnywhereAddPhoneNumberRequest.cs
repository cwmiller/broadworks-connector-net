using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserBroadWorksAnywhereAddPhoneNumberRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _userId;

    [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
    public string UserId {
        get => _userId;
        set {
            UserIdSpecified = true;
            _userId = value;
        }
    }

    [XmlIgnore]
    public bool UserIdSpecified { get; set; }
    private string _phoneNumber;

    [XmlElement(ElementName = "phoneNumber", IsNullable = false, Namespace = "")]
    public string PhoneNumber {
        get => _phoneNumber;
        set {
            PhoneNumberSpecified = true;
            _phoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool PhoneNumberSpecified { get; set; }
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
}
}
