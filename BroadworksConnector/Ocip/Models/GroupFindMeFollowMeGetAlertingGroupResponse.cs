using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupFindMeFollowMeGetAlertingGroupResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _alertingGroupDescription;

    [XmlElement(ElementName = "alertingGroupDescription", IsNullable = false, Namespace = "")]
    public string AlertingGroupDescription {
        get => _alertingGroupDescription;
        set {
            AlertingGroupDescriptionSpecified = true;
            _alertingGroupDescription = value;
        }
    }

    [XmlIgnore]
    public bool AlertingGroupDescriptionSpecified { get; set; }
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
    private int _numberOfRings;

    [XmlElement(ElementName = "numberOfRings", IsNullable = false, Namespace = "")]
    public int NumberOfRings {
        get => _numberOfRings;
        set {
            NumberOfRingsSpecified = true;
            _numberOfRings = value;
        }
    }

    [XmlIgnore]
    public bool NumberOfRingsSpecified { get; set; }
    private List<string> _phoneNumber;

    [XmlElement(ElementName = "phoneNumber", IsNullable = false, Namespace = "")]
    public List<string> PhoneNumber {
        get => _phoneNumber;
        set {
            PhoneNumberSpecified = true;
            _phoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool PhoneNumberSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.C.OCITable _userTable;

    [XmlElement(ElementName = "userTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable UserTable {
        get => _userTable;
        set {
            UserTableSpecified = true;
            _userTable = value;
        }
    }

    [XmlIgnore]
    public bool UserTableSpecified { get; set; }
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
