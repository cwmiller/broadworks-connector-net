using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify an Auto Attendant instance.
    /// The response is either SuccessResponse or ErrorResponse.
    /// Replaced By: GroupAutoAttendantModifyInstanceRequest16
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="GroupAutoAttendantModifyInstanceRequest16"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:3876""}]")]
    public class GroupAutoAttendantModifyInstanceRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:3876")]
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

        private BroadWorksConnector.Ocip.Models.ServiceInstanceModifyProfile _serviceInstanceProfile;

        [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:3876")]
        public BroadWorksConnector.Ocip.Models.ServiceInstanceModifyProfile ServiceInstanceProfile
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

        private bool _enableVideo;

        [XmlElement(ElementName = "enableVideo", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:3876")]
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

        private string _businessHours;

        [XmlElement(ElementName = "businessHours", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:3876")]
        [MinLength(1)]
        [MaxLength(40)]
        public string BusinessHours
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

        private string _holidayScheduleName;

        [XmlElement(ElementName = "holidayScheduleName", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:3876")]
        [MinLength(1)]
        [MaxLength(40)]
        public string HolidayScheduleName
        {
            get => _holidayScheduleName;
            set
            {
                HolidayScheduleNameSpecified = true;
                _holidayScheduleName = value;
            }
        }

        [XmlIgnore]
        protected bool HolidayScheduleNameSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AutoAttendantDialingScope _extensionDialingScope;

        [XmlElement(ElementName = "extensionDialingScope", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:3876")]
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
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:3876")]
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
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:3876")]
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

        private BroadWorksConnector.Ocip.Models.AutoAttendantModifyMenu _businessHoursMenu;

        [XmlElement(ElementName = "businessHoursMenu", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:3876")]
        public BroadWorksConnector.Ocip.Models.AutoAttendantModifyMenu BusinessHoursMenu
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

        private BroadWorksConnector.Ocip.Models.AutoAttendantModifyMenu _afterHoursMenu;

        [XmlElement(ElementName = "afterHoursMenu", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:3876")]
        public BroadWorksConnector.Ocip.Models.AutoAttendantModifyMenu AfterHoursMenu
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

    }
}
