using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the user level data associated with flexible seating guest.
    /// accessDeviceEndpoint can only be configured by group or a higher level administrator.
    /// The request fails if isActive is set to false and the guest is associated to a host.
    /// The request fails when enableAssociationLimit, associationLimitHours, unlockPhonePINCode are changed when the guest is associated to a host.
    /// The request fails when accessDeviceEndpoint is set in the request when the guest is associated to a host.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// 
    /// Replaced by: UserFlexibleSeatingGuestModifyRequest22.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="UserFlexibleSeatingGuestModifyRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:43652""}]")]
    public class UserFlexibleSeatingGuestModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:43652")]
        [MinLength(1)]
        [MaxLength(161)]
        public string UserId
        {
            get => _userId;
            set
            {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        protected bool UserIdSpecified { get; set; }

        protected bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:43652")]
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
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:43652")]
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
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:43652")]
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

        [XmlElement(ElementName = "unlockPhonePINCode", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:43652")]
        [MinLength(4)]
        [MaxLength(10)]
        public string UnlockPhonePINCode
        {
            get => _unlockPhonePINCode;
            set
            {
                UnlockPhonePINCodeSpecified = true;
                _unlockPhonePINCode = value;
            }
        }

        [XmlIgnore]
        protected bool UnlockPhonePINCodeSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AccessDeviceMultipleContactEndpointModify _accessDeviceEndpoint;

        [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:43652")]
        public BroadWorksConnector.Ocip.Models.AccessDeviceMultipleContactEndpointModify AccessDeviceEndpoint
        {
            get => _accessDeviceEndpoint;
            set
            {
                AccessDeviceEndpointSpecified = true;
                _accessDeviceEndpoint = value;
            }
        }

        [XmlIgnore]
        protected bool AccessDeviceEndpointSpecified { get; set; }

        protected string _hostUserId;

        [XmlElement(ElementName = "hostUserId", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:43652")]
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

    }
}
