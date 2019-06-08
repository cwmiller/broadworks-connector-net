using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserHotelingGuestGetResponse14sp4 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
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
    private bool _enableAssociationLimit;

    [XmlElement(ElementName = "enableAssociationLimit", IsNullable = false, Namespace = "")]
    public bool EnableAssociationLimit {
        get => _enableAssociationLimit;
        set {
            EnableAssociationLimitSpecified = true;
            _enableAssociationLimit = value;
        }
    }

    [XmlIgnore]
    public bool EnableAssociationLimitSpecified { get; set; }
    private int _associationLimitHours;

    [XmlElement(ElementName = "associationLimitHours", IsNullable = false, Namespace = "")]
    public int AssociationLimitHours {
        get => _associationLimitHours;
        set {
            AssociationLimitHoursSpecified = true;
            _associationLimitHours = value;
        }
    }

    [XmlIgnore]
    public bool AssociationLimitHoursSpecified { get; set; }
    private string _hostUserId;

    [XmlElement(ElementName = "hostUserId", IsNullable = false, Namespace = "")]
    public string HostUserId {
        get => _hostUserId;
        set {
            HostUserIdSpecified = true;
            _hostUserId = value;
        }
    }

    [XmlIgnore]
    public bool HostUserIdSpecified { get; set; }
    private string _hostLastName;

    [XmlElement(ElementName = "hostLastName", IsNullable = false, Namespace = "")]
    public string HostLastName {
        get => _hostLastName;
        set {
            HostLastNameSpecified = true;
            _hostLastName = value;
        }
    }

    [XmlIgnore]
    public bool HostLastNameSpecified { get; set; }
    private string _hostFirstName;

    [XmlElement(ElementName = "hostFirstName", IsNullable = false, Namespace = "")]
    public string HostFirstName {
        get => _hostFirstName;
        set {
            HostFirstNameSpecified = true;
            _hostFirstName = value;
        }
    }

    [XmlIgnore]
    public bool HostFirstNameSpecified { get; set; }
    private string _hostAssociationDateTime;

    [XmlElement(ElementName = "hostAssociationDateTime", IsNullable = false, Namespace = "")]
    public string HostAssociationDateTime {
        get => _hostAssociationDateTime;
        set {
            HostAssociationDateTimeSpecified = true;
            _hostAssociationDateTime = value;
        }
    }

    [XmlIgnore]
    public bool HostAssociationDateTimeSpecified { get; set; }
    private bool _hostEnforcesAssociationLimit;

    [XmlElement(ElementName = "hostEnforcesAssociationLimit", IsNullable = false, Namespace = "")]
    public bool HostEnforcesAssociationLimit {
        get => _hostEnforcesAssociationLimit;
        set {
            HostEnforcesAssociationLimitSpecified = true;
            _hostEnforcesAssociationLimit = value;
        }
    }

    [XmlIgnore]
    public bool HostEnforcesAssociationLimitSpecified { get; set; }
    private int _hostAssociationLimitHours;

    [XmlElement(ElementName = "hostAssociationLimitHours", IsNullable = false, Namespace = "")]
    public int HostAssociationLimitHours {
        get => _hostAssociationLimitHours;
        set {
            HostAssociationLimitHoursSpecified = true;
            _hostAssociationLimitHours = value;
        }
    }

    [XmlIgnore]
    public bool HostAssociationLimitHoursSpecified { get; set; }
}
}
