using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserHotelingGuestGetRequest14.
    /// Replaced by: UserHotelingGuestGetResponse14sp4
    /// <see cref="UserHotelingGuestGetRequest14"/>
    /// <see cref="UserHotelingGuestGetResponse14sp4"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:7379""}]")]
    public class UserHotelingGuestGetResponse14sp2 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:7379")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:7379")]
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

        private string _hostUserId;

        [XmlElement(ElementName = "hostUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:7379")]
        [MinLength(1)]
        [MaxLength(161)]
        public string HostUserId
        {
            get => _hostUserId;
            set
            {
                HostUserIdSpecified = true;
                _hostUserId = value;
            }
        }

        [XmlIgnore]
        public bool HostUserIdSpecified { get; set; }

        private string _hostLastName;

        [XmlElement(ElementName = "hostLastName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:7379")]
        [MinLength(1)]
        [MaxLength(30)]
        public string HostLastName
        {
            get => _hostLastName;
            set
            {
                HostLastNameSpecified = true;
                _hostLastName = value;
            }
        }

        [XmlIgnore]
        public bool HostLastNameSpecified { get; set; }

        private string _hostFirstName;

        [XmlElement(ElementName = "hostFirstName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:7379")]
        [MinLength(1)]
        [MaxLength(30)]
        public string HostFirstName
        {
            get => _hostFirstName;
            set
            {
                HostFirstNameSpecified = true;
                _hostFirstName = value;
            }
        }

        [XmlIgnore]
        public bool HostFirstNameSpecified { get; set; }

        private string _hostAssociationDateTime;

        [XmlElement(ElementName = "hostAssociationDateTime", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:7379")]
        public string HostAssociationDateTime
        {
            get => _hostAssociationDateTime;
            set
            {
                HostAssociationDateTimeSpecified = true;
                _hostAssociationDateTime = value;
            }
        }

        [XmlIgnore]
        public bool HostAssociationDateTimeSpecified { get; set; }

        private int _hostAssociationLimitHours;

        [XmlElement(ElementName = "hostAssociationLimitHours", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:7379")]
        [MinInclusive(1)]
        [MaxInclusive(999)]
        public int HostAssociationLimitHours
        {
            get => _hostAssociationLimitHours;
            set
            {
                HostAssociationLimitHoursSpecified = true;
                _hostAssociationLimitHours = value;
            }
        }

        [XmlIgnore]
        public bool HostAssociationLimitHoursSpecified { get; set; }

    }
}
