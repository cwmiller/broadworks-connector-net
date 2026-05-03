using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserFlexibleSeatingGuestGetRequest22.
    /// <see cref="UserFlexibleSeatingGuestGetRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1d4e390f8cd01ca6f92589024d74dac6:422""}]")]
    public class UserFlexibleSeatingGuestGetResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"1d4e390f8cd01ca6f92589024d74dac6:422")]
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
        [Group(@"1d4e390f8cd01ca6f92589024d74dac6:422")]
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
        [Group(@"1d4e390f8cd01ca6f92589024d74dac6:422")]
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

        protected string _unlockPhonePINCode;

        [XmlElement(ElementName = "unlockPhonePINCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1d4e390f8cd01ca6f92589024d74dac6:422")]
        [MinLength(4)]
        [MaxLength(10)]
        public string UnlockPhonePINCode
        {
            get => _unlockPhonePINCode;
            set
            {
                UnlockPhonePINCodeSpecified = (value != null);
                _unlockPhonePINCode = value;
            }
        }

        [XmlIgnore]
        protected bool UnlockPhonePINCodeSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AccessDeviceMultipleContactEndpointRead22 _accessDeviceEndpoint;

        [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1d4e390f8cd01ca6f92589024d74dac6:422")]
        public BroadWorksConnector.Ocip.Models.AccessDeviceMultipleContactEndpointRead22 AccessDeviceEndpoint
        {
            get => _accessDeviceEndpoint;
            set
            {
                AccessDeviceEndpointSpecified = (value != null);
                _accessDeviceEndpoint = value;
            }
        }

        [XmlIgnore]
        protected bool AccessDeviceEndpointSpecified { get; set; }

        protected string _hostUserId;

        [XmlElement(ElementName = "hostUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1d4e390f8cd01ca6f92589024d74dac6:422")]
        [MinLength(1)]
        [MaxLength(161)]
        public string HostUserId
        {
            get => _hostUserId;
            set
            {
                HostUserIdSpecified = (value != null);
                _hostUserId = value;
            }
        }

        [XmlIgnore]
        protected bool HostUserIdSpecified { get; set; }

        protected string _hostLastName;

        [XmlElement(ElementName = "hostLastName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1d4e390f8cd01ca6f92589024d74dac6:422")]
        [MinLength(1)]
        [MaxLength(30)]
        public string HostLastName
        {
            get => _hostLastName;
            set
            {
                HostLastNameSpecified = (value != null);
                _hostLastName = value;
            }
        }

        [XmlIgnore]
        protected bool HostLastNameSpecified { get; set; }

        protected string _hostFirstName;

        [XmlElement(ElementName = "hostFirstName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1d4e390f8cd01ca6f92589024d74dac6:422")]
        [MinLength(1)]
        [MaxLength(30)]
        public string HostFirstName
        {
            get => _hostFirstName;
            set
            {
                HostFirstNameSpecified = (value != null);
                _hostFirstName = value;
            }
        }

        [XmlIgnore]
        protected bool HostFirstNameSpecified { get; set; }

        protected string _hostAssociationDateTime;

        [XmlElement(ElementName = "hostAssociationDateTime", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1d4e390f8cd01ca6f92589024d74dac6:422")]
        public string HostAssociationDateTime
        {
            get => _hostAssociationDateTime;
            set
            {
                HostAssociationDateTimeSpecified = (value != null);
                _hostAssociationDateTime = value;
            }
        }

        [XmlIgnore]
        protected bool HostAssociationDateTimeSpecified { get; set; }

        protected bool? _hostEnforcesAssociationLimit;

        [XmlElement(ElementName = "hostEnforcesAssociationLimit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1d4e390f8cd01ca6f92589024d74dac6:422")]
        public bool? HostEnforcesAssociationLimit
        {
            get => _hostEnforcesAssociationLimit;
            set
            {
                HostEnforcesAssociationLimitSpecified = (value != null);
                _hostEnforcesAssociationLimit = value;
            }
        }

        [XmlIgnore]
        protected bool HostEnforcesAssociationLimitSpecified { get; set; }

        protected int? _hostAssociationLimitHours;

        [XmlElement(ElementName = "hostAssociationLimitHours", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1d4e390f8cd01ca6f92589024d74dac6:422")]
        [MinInclusive(1)]
        [MaxInclusive(999)]
        public int? HostAssociationLimitHours
        {
            get => _hostAssociationLimitHours;
            set
            {
                HostAssociationLimitHoursSpecified = (value != null);
                _hostAssociationLimitHours = value;
            }
        }

        [XmlIgnore]
        protected bool HostAssociationLimitHoursSpecified { get; set; }

    }
}
