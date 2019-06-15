using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the group's inventory report.
    /// The response is either a GroupInventoryReportGetResponse or an ErrorResponse.
        /// <see cref="GroupInventoryReportGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupInventoryReportGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private bool _includeUsers;

        [XmlElement(ElementName = "includeUsers", IsNullable = false, Namespace = "")]
        public bool IncludeUsers {
            get => _includeUsers;
            set {
                IncludeUsersSpecified = true;
                _includeUsers = value;
            }
        }

        [XmlIgnore]
        public bool IncludeUsersSpecified { get; set; }
        
        private bool _includeServices;

        [XmlElement(ElementName = "includeServices", IsNullable = false, Namespace = "")]
        public bool IncludeServices {
            get => _includeServices;
            set {
                IncludeServicesSpecified = true;
                _includeServices = value;
            }
        }

        [XmlIgnore]
        public bool IncludeServicesSpecified { get; set; }
        
        private bool _includeDns;

        [XmlElement(ElementName = "includeDns", IsNullable = false, Namespace = "")]
        public bool IncludeDns {
            get => _includeDns;
            set {
                IncludeDnsSpecified = true;
                _includeDns = value;
            }
        }

        [XmlIgnore]
        public bool IncludeDnsSpecified { get; set; }
        
        private bool _includeAccessDevices;

        [XmlElement(ElementName = "includeAccessDevices", IsNullable = false, Namespace = "")]
        public bool IncludeAccessDevices {
            get => _includeAccessDevices;
            set {
                IncludeAccessDevicesSpecified = true;
                _includeAccessDevices = value;
            }
        }

        [XmlIgnore]
        public bool IncludeAccessDevicesSpecified { get; set; }
        
        private bool _includeDepartments;

        [XmlElement(ElementName = "includeDepartments", IsNullable = false, Namespace = "")]
        public bool IncludeDepartments {
            get => _includeDepartments;
            set {
                IncludeDepartmentsSpecified = true;
                _includeDepartments = value;
            }
        }

        [XmlIgnore]
        public bool IncludeDepartmentsSpecified { get; set; }
        
        private string _reportDeliveryEmailAddress;

        [XmlElement(ElementName = "reportDeliveryEmailAddress", IsNullable = false, Namespace = "")]
        public string ReportDeliveryEmailAddress {
            get => _reportDeliveryEmailAddress;
            set {
                ReportDeliveryEmailAddressSpecified = true;
                _reportDeliveryEmailAddress = value;
            }
        }

        [XmlIgnore]
        public bool ReportDeliveryEmailAddressSpecified { get; set; }
        
    }
}
