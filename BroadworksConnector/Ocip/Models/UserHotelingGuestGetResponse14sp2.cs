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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:45430""}]")]
    public class UserHotelingGuestGetResponse14sp2 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:45430")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:45430")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:45430")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:45430")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:45430")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:45430")]
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

        protected int _hostAssociationLimitHours;

        [XmlElement(ElementName = "hostAssociationLimitHours", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:45430")]
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
        protected bool HostAssociationLimitHoursSpecified { get; set; }

    }
}
