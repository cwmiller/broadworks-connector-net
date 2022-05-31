using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserHotelingGuestGetRequest14.
    /// Replaced By: UserSharedCallAppearanceAddEndpointRequest14sp2
    /// <see cref="UserHotelingGuestGetRequest14"/>
    /// <see cref="UserSharedCallAppearanceAddEndpointRequest14sp2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:44787""}]")]
    public class UserHotelingGuestGetResponse14 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:44787")]
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
        protected bool IsActiveSpecified { get; set; }

        protected int _associationLimitHours;

        [XmlElement(ElementName = "associationLimitHours", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:44787")]
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
        protected bool AssociationLimitHoursSpecified { get; set; }

        protected string _hostUserId;

        [XmlElement(ElementName = "hostUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:44787")]
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
        protected bool HostUserIdSpecified { get; set; }

        protected string _hostLastName;

        [XmlElement(ElementName = "hostLastName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:44787")]
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
        protected bool HostLastNameSpecified { get; set; }

        protected string _hostFirstName;

        [XmlElement(ElementName = "hostFirstName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:44787")]
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
        protected bool HostFirstNameSpecified { get; set; }

        protected string _hostAssociationDateTime;

        [XmlElement(ElementName = "hostAssociationDateTime", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:44787")]
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
        protected bool HostAssociationDateTimeSpecified { get; set; }

    }
}
