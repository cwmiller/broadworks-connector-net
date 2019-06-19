using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserHotelingHostGetRequest14.
    /// Replaced by: UserHotelingHostGetResponse14sp4
    /// <see cref="UserHotelingHostGetRequest14"/>
    /// <see cref="UserHotelingHostGetResponse14sp4"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:7418""}]")]
    public class UserHotelingHostGetResponse14 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:7418")]
        public bool IsActive
        {
            get => _isActive;
            set
            {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        public bool IsActiveSpecified { get; set; }

        private int _associationLimitHours;

        [XmlElement(ElementName = "associationLimitHours", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:7418")]
        [MinInclusive(1)]
        [MaxInclusive(999)]
        public int AssociationLimitHours
        {
            get => _associationLimitHours;
            set
            {
                AssociationLimitHoursSpecified = true;
                _associationLimitHours = value;
            }
        }

        [XmlIgnore]
        public bool AssociationLimitHoursSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.HotelingHostAccessLevel _accessLevel;

        [XmlElement(ElementName = "accessLevel", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:7418")]
        public BroadWorksConnector.Ocip.Models.HotelingHostAccessLevel AccessLevel
        {
            get => _accessLevel;
            set
            {
                AccessLevelSpecified = true;
                _accessLevel = value;
            }
        }

        [XmlIgnore]
        public bool AccessLevelSpecified { get; set; }

        private string _guestLastName;

        [XmlElement(ElementName = "guestLastName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:7418")]
        [MinLength(1)]
        [MaxLength(30)]
        public string GuestLastName
        {
            get => _guestLastName;
            set
            {
                GuestLastNameSpecified = true;
                _guestLastName = value;
            }
        }

        [XmlIgnore]
        public bool GuestLastNameSpecified { get; set; }

        private string _guestFirstName;

        [XmlElement(ElementName = "guestFirstName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:7418")]
        [MinLength(1)]
        [MaxLength(30)]
        public string GuestFirstName
        {
            get => _guestFirstName;
            set
            {
                GuestFirstNameSpecified = true;
                _guestFirstName = value;
            }
        }

        [XmlIgnore]
        public bool GuestFirstNameSpecified { get; set; }

        private string _guestPhoneNumber;

        [XmlElement(ElementName = "guestPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:7418")]
        [MinLength(1)]
        [MaxLength(23)]
        public string GuestPhoneNumber
        {
            get => _guestPhoneNumber;
            set
            {
                GuestPhoneNumberSpecified = true;
                _guestPhoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool GuestPhoneNumberSpecified { get; set; }

        private string _guestExtension;

        [XmlElement(ElementName = "guestExtension", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:7418")]
        [MinLength(2)]
        [MaxLength(6)]
        public string GuestExtension
        {
            get => _guestExtension;
            set
            {
                GuestExtensionSpecified = true;
                _guestExtension = value;
            }
        }

        [XmlIgnore]
        public bool GuestExtensionSpecified { get; set; }

        private string _guestLocationDialingCode;

        [XmlElement(ElementName = "guestLocationDialingCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:7418")]
        [MinLength(1)]
        [MaxLength(15)]
        public string GuestLocationDialingCode
        {
            get => _guestLocationDialingCode;
            set
            {
                GuestLocationDialingCodeSpecified = true;
                _guestLocationDialingCode = value;
            }
        }

        [XmlIgnore]
        public bool GuestLocationDialingCodeSpecified { get; set; }

        private string _guestAssociationDateTime;

        [XmlElement(ElementName = "guestAssociationDateTime", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:7418")]
        public string GuestAssociationDateTime
        {
            get => _guestAssociationDateTime;
            set
            {
                GuestAssociationDateTimeSpecified = true;
                _guestAssociationDateTime = value;
            }
        }

        [XmlIgnore]
        public bool GuestAssociationDateTimeSpecified { get; set; }

    }
}
