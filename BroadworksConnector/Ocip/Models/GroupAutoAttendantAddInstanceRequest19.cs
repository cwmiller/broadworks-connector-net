using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a Auto Attendant instance to a group.
    /// The domain is required in the serviceUserId.
    /// Only Group and Enterprise level schedules are accepted.
    /// The response is either SuccessResponse or ErrorResponse.
    /// The following elements are only used in AS data mode:
    /// type, use value "Basic" in XS data mode
    /// The following elements are only used in AS data mode and ignored in XS data mode:
    /// holidayMenu
    /// The following elements are only valid for Standard Auto Attendants:
    /// holidayMenu
    /// 
    /// Replaced by: GroupAutoAttendantAddInstanceRequest20 in AS data mode
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="GroupAutoAttendantAddInstanceRequest20"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupAutoAttendantAddInstanceRequest19 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        public string ServiceProviderId {
            get => _serviceProviderId;
            set {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderIdSpecified { get; set; }
        
        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        public string GroupId {
            get => _groupId;
            set {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        public bool GroupIdSpecified { get; set; }
        
        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        public string ServiceUserId {
            get => _serviceUserId;
            set {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceUserIdSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ServiceInstanceAddProfile _serviceInstanceProfile;

        [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ServiceInstanceAddProfile ServiceInstanceProfile {
            get => _serviceInstanceProfile;
            set {
                ServiceInstanceProfileSpecified = true;
                _serviceInstanceProfile = value;
            }
        }

        [XmlIgnore]
        public bool ServiceInstanceProfileSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.AutoAttendantType _type;

        [XmlElement(ElementName = "type", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.AutoAttendantType Type {
            get => _type;
            set {
                TypeSpecified = true;
                _type = value;
            }
        }

        [XmlIgnore]
        public bool TypeSpecified { get; set; }
        
        private bool _enableVideo;

        [XmlElement(ElementName = "enableVideo", IsNullable = false, Namespace = "")]
        public bool EnableVideo {
            get => _enableVideo;
            set {
                EnableVideoSpecified = true;
                _enableVideo = value;
            }
        }

        [XmlIgnore]
        public bool EnableVideoSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.TimeSchedule _businessHours;

        [XmlElement(ElementName = "businessHours", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.TimeSchedule BusinessHours {
            get => _businessHours;
            set {
                BusinessHoursSpecified = true;
                _businessHours = value;
            }
        }

        [XmlIgnore]
        public bool BusinessHoursSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.HolidaySchedule _holidaySchedule;

        [XmlElement(ElementName = "holidaySchedule", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.HolidaySchedule HolidaySchedule {
            get => _holidaySchedule;
            set {
                HolidayScheduleSpecified = true;
                _holidaySchedule = value;
            }
        }

        [XmlIgnore]
        public bool HolidayScheduleSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.AutoAttendantDialingScope _extensionDialingScope;

        [XmlElement(ElementName = "extensionDialingScope", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.AutoAttendantDialingScope ExtensionDialingScope {
            get => _extensionDialingScope;
            set {
                ExtensionDialingScopeSpecified = true;
                _extensionDialingScope = value;
            }
        }

        [XmlIgnore]
        public bool ExtensionDialingScopeSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.AutoAttendantDialingScope _nameDialingScope;

        [XmlElement(ElementName = "nameDialingScope", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.AutoAttendantDialingScope NameDialingScope {
            get => _nameDialingScope;
            set {
                NameDialingScopeSpecified = true;
                _nameDialingScope = value;
            }
        }

        [XmlIgnore]
        public bool NameDialingScopeSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.AutoAttendantNameDialingEntry _nameDialingEntries;

        [XmlElement(ElementName = "nameDialingEntries", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.AutoAttendantNameDialingEntry NameDialingEntries {
            get => _nameDialingEntries;
            set {
                NameDialingEntriesSpecified = true;
                _nameDialingEntries = value;
            }
        }

        [XmlIgnore]
        public bool NameDialingEntriesSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.AutoAttendantAddMenu19 _businessHoursMenu;

        [XmlElement(ElementName = "businessHoursMenu", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.AutoAttendantAddMenu19 BusinessHoursMenu {
            get => _businessHoursMenu;
            set {
                BusinessHoursMenuSpecified = true;
                _businessHoursMenu = value;
            }
        }

        [XmlIgnore]
        public bool BusinessHoursMenuSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.AutoAttendantAddMenu19 _afterHoursMenu;

        [XmlElement(ElementName = "afterHoursMenu", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.AutoAttendantAddMenu19 AfterHoursMenu {
            get => _afterHoursMenu;
            set {
                AfterHoursMenuSpecified = true;
                _afterHoursMenu = value;
            }
        }

        [XmlIgnore]
        public bool AfterHoursMenuSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.AutoAttendantAddMenu19 _holidayMenu;

        [XmlElement(ElementName = "holidayMenu", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.AutoAttendantAddMenu19 HolidayMenu {
            get => _holidayMenu;
            set {
                HolidayMenuSpecified = true;
                _holidayMenu = value;
            }
        }

        [XmlIgnore]
        public bool HolidayMenuSpecified { get; set; }
        
        private string _networkClassOfService;

        [XmlElement(ElementName = "networkClassOfService", IsNullable = false, Namespace = "")]
        public string NetworkClassOfService {
            get => _networkClassOfService;
            set {
                NetworkClassOfServiceSpecified = true;
                _networkClassOfService = value;
            }
        }

        [XmlIgnore]
        public bool NetworkClassOfServiceSpecified { get; set; }
        
    }
}
