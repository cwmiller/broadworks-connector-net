using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserHotelingGuestGetRequest14sp4
    /// <see cref="UserHotelingGuestGetRequest14sp4"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b3a47d1de480374e33d6efb9aa2bd2d0:98""}]")]
    public class UserHotelingGuestGetResponse14sp4 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"b3a47d1de480374e33d6efb9aa2bd2d0:98")]
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

        protected bool _enableAssociationLimit;

        [XmlElement(ElementName = "enableAssociationLimit", IsNullable = false, Namespace = "")]
        [Group(@"b3a47d1de480374e33d6efb9aa2bd2d0:98")]
        public bool EnableAssociationLimit
        {
            get => _enableAssociationLimit;
            set
            {
                EnableAssociationLimitSpecified = true;
                _enableAssociationLimit = value;
            }
        }

        [XmlIgnore]
        protected bool EnableAssociationLimitSpecified { get; set; }

        protected int _associationLimitHours;

        [XmlElement(ElementName = "associationLimitHours", IsNullable = false, Namespace = "")]
        [Group(@"b3a47d1de480374e33d6efb9aa2bd2d0:98")]
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
        [Group(@"b3a47d1de480374e33d6efb9aa2bd2d0:98")]
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
        [Group(@"b3a47d1de480374e33d6efb9aa2bd2d0:98")]
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
        [Group(@"b3a47d1de480374e33d6efb9aa2bd2d0:98")]
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
        [Group(@"b3a47d1de480374e33d6efb9aa2bd2d0:98")]
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

        protected bool _hostEnforcesAssociationLimit;

        [XmlElement(ElementName = "hostEnforcesAssociationLimit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b3a47d1de480374e33d6efb9aa2bd2d0:98")]
        public bool HostEnforcesAssociationLimit
        {
            get => _hostEnforcesAssociationLimit;
            set
            {
                HostEnforcesAssociationLimitSpecified = true;
                _hostEnforcesAssociationLimit = value;
            }
        }

        [XmlIgnore]
        protected bool HostEnforcesAssociationLimitSpecified { get; set; }

        protected int _hostAssociationLimitHours;

        [XmlElement(ElementName = "hostAssociationLimitHours", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b3a47d1de480374e33d6efb9aa2bd2d0:98")]
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
