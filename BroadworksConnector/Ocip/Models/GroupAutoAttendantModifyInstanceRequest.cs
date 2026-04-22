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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:4007""}]")]
    public class GroupAutoAttendantModifyInstanceRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:4007")]
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

        protected BroadWorksConnector.Ocip.Models.ServiceInstanceModifyProfile _serviceInstanceProfile;

        [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:4007")]
        public BroadWorksConnector.Ocip.Models.ServiceInstanceModifyProfile ServiceInstanceProfile
        {
            get => _serviceInstanceProfile;
            set
            {
                ServiceInstanceProfileSpecified = (value != null);
                _serviceInstanceProfile = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceInstanceProfileSpecified { get; set; }

        protected bool? _enableVideo;

        [XmlElement(ElementName = "enableVideo", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:4007")]
        public bool? EnableVideo
        {
            get => _enableVideo;
            set
            {
                EnableVideoSpecified = (value != null);
                _enableVideo = value;
            }
        }

        [XmlIgnore]
        protected bool EnableVideoSpecified { get; set; }

        protected string _businessHours;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "businessHours", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:4007")]
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

        protected string _holidayScheduleName;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "holidayScheduleName", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:4007")]
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

        protected BroadWorksConnector.Ocip.Models.AutoAttendantDialingScope? _extensionDialingScope;

        [XmlElement(ElementName = "extensionDialingScope", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:4007")]
        public BroadWorksConnector.Ocip.Models.AutoAttendantDialingScope? ExtensionDialingScope
        {
            get => _extensionDialingScope;
            set
            {
                ExtensionDialingScopeSpecified = (value != null);
                _extensionDialingScope = value;
            }
        }

        [XmlIgnore]
        protected bool ExtensionDialingScopeSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AutoAttendantDialingScope? _nameDialingScope;

        [XmlElement(ElementName = "nameDialingScope", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:4007")]
        public BroadWorksConnector.Ocip.Models.AutoAttendantDialingScope? NameDialingScope
        {
            get => _nameDialingScope;
            set
            {
                NameDialingScopeSpecified = (value != null);
                _nameDialingScope = value;
            }
        }

        [XmlIgnore]
        protected bool NameDialingScopeSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AutoAttendantNameDialingEntry? _nameDialingEntries;

        [XmlElement(ElementName = "nameDialingEntries", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:4007")]
        public BroadWorksConnector.Ocip.Models.AutoAttendantNameDialingEntry? NameDialingEntries
        {
            get => _nameDialingEntries;
            set
            {
                NameDialingEntriesSpecified = (value != null);
                _nameDialingEntries = value;
            }
        }

        [XmlIgnore]
        protected bool NameDialingEntriesSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AutoAttendantModifyMenu _businessHoursMenu;

        [XmlElement(ElementName = "businessHoursMenu", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:4007")]
        public BroadWorksConnector.Ocip.Models.AutoAttendantModifyMenu BusinessHoursMenu
        {
            get => _businessHoursMenu;
            set
            {
                BusinessHoursMenuSpecified = (value != null);
                _businessHoursMenu = value;
            }
        }

        [XmlIgnore]
        protected bool BusinessHoursMenuSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AutoAttendantModifyMenu _afterHoursMenu;

        [XmlElement(ElementName = "afterHoursMenu", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:4007")]
        public BroadWorksConnector.Ocip.Models.AutoAttendantModifyMenu AfterHoursMenu
        {
            get => _afterHoursMenu;
            set
            {
                AfterHoursMenuSpecified = (value != null);
                _afterHoursMenu = value;
            }
        }

        [XmlIgnore]
        protected bool AfterHoursMenuSpecified { get; set; }

    }
}
