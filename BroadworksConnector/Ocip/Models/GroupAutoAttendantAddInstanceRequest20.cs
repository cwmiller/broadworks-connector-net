using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a Auto Attendant instance to a group.
    /// The domain is required in the serviceUserId.
    /// Only Group and Enterprise level schedules are accepted.
    /// The response is either SuccessResponse or ErrorResponse.
    /// 
    /// The following elements are only used in AS data mode:
    /// type, use AutoAttendantType.BASIC in XS mode.
    /// holidayMenu.
    /// The following elements are only valid for Standard Auto
    /// Attendants:
    /// holidayMenu
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ec63a55bc41262b2dd33a1f4e8e84674:66""}]")]
    public class GroupAutoAttendantAddInstanceRequest20 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"ec63a55bc41262b2dd33a1f4e8e84674:66")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }

        protected string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"ec63a55bc41262b2dd33a1f4e8e84674:66")]
        [MinLength(1)]
        [MaxLength(30)]
        public string GroupId
        {
            get => _groupId;
            set
            {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        protected bool GroupIdSpecified { get; set; }

        protected string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"ec63a55bc41262b2dd33a1f4e8e84674:66")]
        [MinLength(1)]
        [MaxLength(161)]
        public string ServiceUserId
        {
            get => _serviceUserId;
            set
            {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceUserIdSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceInstanceAddProfile _serviceInstanceProfile;

        [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
        [Group(@"ec63a55bc41262b2dd33a1f4e8e84674:66")]
        public BroadWorksConnector.Ocip.Models.ServiceInstanceAddProfile ServiceInstanceProfile
        {
            get => _serviceInstanceProfile;
            set
            {
                ServiceInstanceProfileSpecified = true;
                _serviceInstanceProfile = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceInstanceProfileSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AutoAttendantType _type;

        [XmlElement(ElementName = "type", IsNullable = false, Namespace = "")]
        [Group(@"ec63a55bc41262b2dd33a1f4e8e84674:66")]
        public BroadWorksConnector.Ocip.Models.AutoAttendantType Type
        {
            get => _type;
            set
            {
                TypeSpecified = true;
                _type = value;
            }
        }

        [XmlIgnore]
        protected bool TypeSpecified { get; set; }

        protected int _firstDigitTimeoutSeconds;

        [XmlElement(ElementName = "firstDigitTimeoutSeconds", IsNullable = false, Namespace = "")]
        [Group(@"ec63a55bc41262b2dd33a1f4e8e84674:66")]
        [MinInclusive(1)]
        [MaxInclusive(60)]
        public int FirstDigitTimeoutSeconds
        {
            get => _firstDigitTimeoutSeconds;
            set
            {
                FirstDigitTimeoutSecondsSpecified = true;
                _firstDigitTimeoutSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool FirstDigitTimeoutSecondsSpecified { get; set; }

        protected bool _enableVideo;

        [XmlElement(ElementName = "enableVideo", IsNullable = false, Namespace = "")]
        [Group(@"ec63a55bc41262b2dd33a1f4e8e84674:66")]
        public bool EnableVideo
        {
            get => _enableVideo;
            set
            {
                EnableVideoSpecified = true;
                _enableVideo = value;
            }
        }

        [XmlIgnore]
        protected bool EnableVideoSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.TimeSchedule _businessHours;

        [XmlElement(ElementName = "businessHours", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ec63a55bc41262b2dd33a1f4e8e84674:66")]
        public BroadWorksConnector.Ocip.Models.TimeSchedule BusinessHours
        {
            get => _businessHours;
            set
            {
                BusinessHoursSpecified = true;
                _businessHours = value;
            }
        }

        [XmlIgnore]
        protected bool BusinessHoursSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.HolidaySchedule _holidaySchedule;

        [XmlElement(ElementName = "holidaySchedule", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ec63a55bc41262b2dd33a1f4e8e84674:66")]
        public BroadWorksConnector.Ocip.Models.HolidaySchedule HolidaySchedule
        {
            get => _holidaySchedule;
            set
            {
                HolidayScheduleSpecified = true;
                _holidaySchedule = value;
            }
        }

        [XmlIgnore]
        protected bool HolidayScheduleSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AutoAttendantDialingScope _extensionDialingScope;

        [XmlElement(ElementName = "extensionDialingScope", IsNullable = false, Namespace = "")]
        [Group(@"ec63a55bc41262b2dd33a1f4e8e84674:66")]
        public BroadWorksConnector.Ocip.Models.AutoAttendantDialingScope ExtensionDialingScope
        {
            get => _extensionDialingScope;
            set
            {
                ExtensionDialingScopeSpecified = true;
                _extensionDialingScope = value;
            }
        }

        [XmlIgnore]
        protected bool ExtensionDialingScopeSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AutoAttendantDialingScope _nameDialingScope;

        [XmlElement(ElementName = "nameDialingScope", IsNullable = false, Namespace = "")]
        [Group(@"ec63a55bc41262b2dd33a1f4e8e84674:66")]
        public BroadWorksConnector.Ocip.Models.AutoAttendantDialingScope NameDialingScope
        {
            get => _nameDialingScope;
            set
            {
                NameDialingScopeSpecified = true;
                _nameDialingScope = value;
            }
        }

        [XmlIgnore]
        protected bool NameDialingScopeSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AutoAttendantNameDialingEntry _nameDialingEntries;

        [XmlElement(ElementName = "nameDialingEntries", IsNullable = false, Namespace = "")]
        [Group(@"ec63a55bc41262b2dd33a1f4e8e84674:66")]
        public BroadWorksConnector.Ocip.Models.AutoAttendantNameDialingEntry NameDialingEntries
        {
            get => _nameDialingEntries;
            set
            {
                NameDialingEntriesSpecified = true;
                _nameDialingEntries = value;
            }
        }

        [XmlIgnore]
        protected bool NameDialingEntriesSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AutoAttendantAddMenu20 _businessHoursMenu;

        [XmlElement(ElementName = "businessHoursMenu", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ec63a55bc41262b2dd33a1f4e8e84674:66")]
        public BroadWorksConnector.Ocip.Models.AutoAttendantAddMenu20 BusinessHoursMenu
        {
            get => _businessHoursMenu;
            set
            {
                BusinessHoursMenuSpecified = true;
                _businessHoursMenu = value;
            }
        }

        [XmlIgnore]
        protected bool BusinessHoursMenuSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AutoAttendantAddMenu20 _afterHoursMenu;

        [XmlElement(ElementName = "afterHoursMenu", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ec63a55bc41262b2dd33a1f4e8e84674:66")]
        public BroadWorksConnector.Ocip.Models.AutoAttendantAddMenu20 AfterHoursMenu
        {
            get => _afterHoursMenu;
            set
            {
                AfterHoursMenuSpecified = true;
                _afterHoursMenu = value;
            }
        }

        [XmlIgnore]
        protected bool AfterHoursMenuSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AutoAttendantAddMenu20 _holidayMenu;

        [XmlElement(ElementName = "holidayMenu", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ec63a55bc41262b2dd33a1f4e8e84674:66")]
        public BroadWorksConnector.Ocip.Models.AutoAttendantAddMenu20 HolidayMenu
        {
            get => _holidayMenu;
            set
            {
                HolidayMenuSpecified = true;
                _holidayMenu = value;
            }
        }

        [XmlIgnore]
        protected bool HolidayMenuSpecified { get; set; }

        protected string _networkClassOfService;

        [XmlElement(ElementName = "networkClassOfService", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ec63a55bc41262b2dd33a1f4e8e84674:66")]
        [MinLength(1)]
        [MaxLength(40)]
        public string NetworkClassOfService
        {
            get => _networkClassOfService;
            set
            {
                NetworkClassOfServiceSpecified = true;
                _networkClassOfService = value;
            }
        }

        [XmlIgnore]
        protected bool NetworkClassOfServiceSpecified { get; set; }

    }
}
