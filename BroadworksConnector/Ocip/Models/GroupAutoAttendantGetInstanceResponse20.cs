using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupAutoAttendantGetInstanceRequest20.
    /// Contains the service profile information.
    /// 
    /// 
    /// The following elements are only used in AS data mode:
    /// type, use AutoAttendantType.BASIC in XS mode.
    /// holidayMenu.
    /// The following elements are only valid for Standard Auto
    /// Attendants:
    /// holidayMenu
    /// <see cref="GroupAutoAttendantGetInstanceRequest20"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ed0640d8ef49eb8b4eaa14d7c6f6c033:360""}]")]
    public class GroupAutoAttendantGetInstanceResponse20 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.ServiceInstanceReadProfile19sp1 _serviceInstanceProfile;

        [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
        [Group(@"ed0640d8ef49eb8b4eaa14d7c6f6c033:360")]
        public BroadWorksConnector.Ocip.Models.ServiceInstanceReadProfile19sp1 ServiceInstanceProfile
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

        private BroadWorksConnector.Ocip.Models.AutoAttendantType _type;

        [XmlElement(ElementName = "type", IsNullable = false, Namespace = "")]
        [Group(@"ed0640d8ef49eb8b4eaa14d7c6f6c033:360")]
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

        private int _firstDigitTimeoutSeconds;

        [XmlElement(ElementName = "firstDigitTimeoutSeconds", IsNullable = false, Namespace = "")]
        [Group(@"ed0640d8ef49eb8b4eaa14d7c6f6c033:360")]
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

        private bool _enableVideo;

        [XmlElement(ElementName = "enableVideo", IsNullable = false, Namespace = "")]
        [Group(@"ed0640d8ef49eb8b4eaa14d7c6f6c033:360")]
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

        private BroadWorksConnector.Ocip.Models.TimeSchedule _businessHours;

        [XmlElement(ElementName = "businessHours", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ed0640d8ef49eb8b4eaa14d7c6f6c033:360")]
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

        private BroadWorksConnector.Ocip.Models.HolidaySchedule _holidaySchedule;

        [XmlElement(ElementName = "holidaySchedule", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ed0640d8ef49eb8b4eaa14d7c6f6c033:360")]
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

        private BroadWorksConnector.Ocip.Models.AutoAttendantDialingScope _extensionDialingScope;

        [XmlElement(ElementName = "extensionDialingScope", IsNullable = false, Namespace = "")]
        [Group(@"ed0640d8ef49eb8b4eaa14d7c6f6c033:360")]
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

        private BroadWorksConnector.Ocip.Models.AutoAttendantDialingScope _nameDialingScope;

        [XmlElement(ElementName = "nameDialingScope", IsNullable = false, Namespace = "")]
        [Group(@"ed0640d8ef49eb8b4eaa14d7c6f6c033:360")]
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

        private BroadWorksConnector.Ocip.Models.AutoAttendantNameDialingEntry _nameDialingEntries;

        [XmlElement(ElementName = "nameDialingEntries", IsNullable = false, Namespace = "")]
        [Group(@"ed0640d8ef49eb8b4eaa14d7c6f6c033:360")]
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

        private BroadWorksConnector.Ocip.Models.AutoAttendantReadMenu20 _businessHoursMenu;

        [XmlElement(ElementName = "businessHoursMenu", IsNullable = false, Namespace = "")]
        [Group(@"ed0640d8ef49eb8b4eaa14d7c6f6c033:360")]
        public BroadWorksConnector.Ocip.Models.AutoAttendantReadMenu20 BusinessHoursMenu
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

        private BroadWorksConnector.Ocip.Models.AutoAttendantReadMenu20 _afterHoursMenu;

        [XmlElement(ElementName = "afterHoursMenu", IsNullable = false, Namespace = "")]
        [Group(@"ed0640d8ef49eb8b4eaa14d7c6f6c033:360")]
        public BroadWorksConnector.Ocip.Models.AutoAttendantReadMenu20 AfterHoursMenu
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

        private BroadWorksConnector.Ocip.Models.AutoAttendantReadMenu20 _holidayMenu;

        [XmlElement(ElementName = "holidayMenu", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ed0640d8ef49eb8b4eaa14d7c6f6c033:360")]
        public BroadWorksConnector.Ocip.Models.AutoAttendantReadMenu20 HolidayMenu
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

        private string _networkClassOfService;

        [XmlElement(ElementName = "networkClassOfService", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ed0640d8ef49eb8b4eaa14d7c6f6c033:360")]
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
