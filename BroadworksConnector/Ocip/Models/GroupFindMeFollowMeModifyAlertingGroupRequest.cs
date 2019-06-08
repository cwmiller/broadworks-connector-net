using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupFindMeFollowMeModifyAlertingGroupRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceUserId;

    [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
    public string ServiceUserId {
        get => _serviceUserId;
        set {
            ServiceUserIdSpecified = true;
            _serviceUserId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceUserIdSpecified { get; set; }
    private string _alertingGroupName;

    [XmlElement(ElementName = "alertingGroupName", IsNullable = false, Namespace = "")]
    public string AlertingGroupName {
        get => _alertingGroupName;
        set {
            AlertingGroupNameSpecified = true;
            _alertingGroupName = value;
        }
    }

    [XmlIgnore]
    public bool AlertingGroupNameSpecified { get; set; }
    private string _newAlertingGroupName;

    [XmlElement(ElementName = "newAlertingGroupName", IsNullable = false, Namespace = "")]
    public string NewAlertingGroupName {
        get => _newAlertingGroupName;
        set {
            NewAlertingGroupNameSpecified = true;
            _newAlertingGroupName = value;
        }
    }

    [XmlIgnore]
    public bool NewAlertingGroupNameSpecified { get; set; }
    private string _alertingGroupDescription;

    [XmlElement(ElementName = "alertingGroupDescription", IsNullable = true, Namespace = "")]
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
    private BroadWorksConnector.Ocip.Models.FindMeFollowMeAlertingGroupReplacementOutgoingDNSIPURIorUserIdList _phoneNumberOrUserList;

    [XmlElement(ElementName = "phoneNumberOrUserList", IsNullable = true, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.FindMeFollowMeAlertingGroupReplacementOutgoingDNSIPURIorUserIdList PhoneNumberOrUserList {
        get => _phoneNumberOrUserList;
        set {
            PhoneNumberOrUserListSpecified = true;
            _phoneNumberOrUserList = value;
        }
    }

    [XmlIgnore]
    public bool PhoneNumberOrUserListSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.CriteriaActivation> _criteriaActivation;

    [XmlElement(ElementName = "criteriaActivation", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.CriteriaActivation> CriteriaActivation {
        get => _criteriaActivation;
        set {
            CriteriaActivationSpecified = true;
            _criteriaActivation = value;
        }
    }

    [XmlIgnore]
    public bool CriteriaActivationSpecified { get; set; }
}
}
