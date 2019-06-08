using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupFlexibleSeatingHostGuestAssociationGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _enforceAssociationLimit;

    [XmlElement(ElementName = "enforceAssociationLimit", IsNullable = false, Namespace = "")]
    public bool EnforceAssociationLimit {
        get => _enforceAssociationLimit;
        set {
            EnforceAssociationLimitSpecified = true;
            _enforceAssociationLimit = value;
        }
    }

    [XmlIgnore]
    public bool EnforceAssociationLimitSpecified { get; set; }
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
    private BroadWorksConnector.Ocip.Models.FlexibleSeatingHostAccessLevel _accessLevel;

    [XmlElement(ElementName = "accessLevel", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.FlexibleSeatingHostAccessLevel AccessLevel {
        get => _accessLevel;
        set {
            AccessLevelSpecified = true;
            _accessLevel = value;
        }
    }

    [XmlIgnore]
    public bool AccessLevelSpecified { get; set; }
    private string _guestLastName;

    [XmlElement(ElementName = "guestLastName", IsNullable = false, Namespace = "")]
    public string GuestLastName {
        get => _guestLastName;
        set {
            GuestLastNameSpecified = true;
            _guestLastName = value;
        }
    }

    [XmlIgnore]
    public bool GuestLastNameSpecified { get; set; }
    private string _guestFirstName;

    [XmlElement(ElementName = "guestFirstName", IsNullable = false, Namespace = "")]
    public string GuestFirstName {
        get => _guestFirstName;
        set {
            GuestFirstNameSpecified = true;
            _guestFirstName = value;
        }
    }

    [XmlIgnore]
    public bool GuestFirstNameSpecified { get; set; }
    private string _guestPhoneNumber;

    [XmlElement(ElementName = "guestPhoneNumber", IsNullable = false, Namespace = "")]
    public string GuestPhoneNumber {
        get => _guestPhoneNumber;
        set {
            GuestPhoneNumberSpecified = true;
            _guestPhoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool GuestPhoneNumberSpecified { get; set; }
    private string _guestExtension;

    [XmlElement(ElementName = "guestExtension", IsNullable = false, Namespace = "")]
    public string GuestExtension {
        get => _guestExtension;
        set {
            GuestExtensionSpecified = true;
            _guestExtension = value;
        }
    }

    [XmlIgnore]
    public bool GuestExtensionSpecified { get; set; }
    private string _guestLocationDialingCode;

    [XmlElement(ElementName = "guestLocationDialingCode", IsNullable = false, Namespace = "")]
    public string GuestLocationDialingCode {
        get => _guestLocationDialingCode;
        set {
            GuestLocationDialingCodeSpecified = true;
            _guestLocationDialingCode = value;
        }
    }

    [XmlIgnore]
    public bool GuestLocationDialingCodeSpecified { get; set; }
    private string _guestAssociationDateTime;

    [XmlElement(ElementName = "guestAssociationDateTime", IsNullable = false, Namespace = "")]
    public string GuestAssociationDateTime {
        get => _guestAssociationDateTime;
        set {
            GuestAssociationDateTimeSpecified = true;
            _guestAssociationDateTime = value;
        }
    }

    [XmlIgnore]
    public bool GuestAssociationDateTimeSpecified { get; set; }
}
}
