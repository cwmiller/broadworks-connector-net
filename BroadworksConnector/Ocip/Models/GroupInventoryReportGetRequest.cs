using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""5c0fc3a03773b4f430e938115770c82d:42""}]")]
    public class GroupInventoryReportGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.GroupInventoryReportGetResponse>
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"5c0fc3a03773b4f430e938115770c82d:42")]
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

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"5c0fc3a03773b4f430e938115770c82d:42")]
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

        private bool _includeUsers;

        [XmlElement(ElementName = "includeUsers", IsNullable = false, Namespace = "")]
        [Group(@"5c0fc3a03773b4f430e938115770c82d:42")]
        public bool IncludeUsers
        {
            get => _includeUsers;
            set
            {
                IncludeUsersSpecified = true;
                _includeUsers = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeUsersSpecified { get; set; }

        private bool _includeServices;

        [XmlElement(ElementName = "includeServices", IsNullable = false, Namespace = "")]
        [Group(@"5c0fc3a03773b4f430e938115770c82d:42")]
        public bool IncludeServices
        {
            get => _includeServices;
            set
            {
                IncludeServicesSpecified = true;
                _includeServices = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeServicesSpecified { get; set; }

        private bool _includeDns;

        [XmlElement(ElementName = "includeDns", IsNullable = false, Namespace = "")]
        [Group(@"5c0fc3a03773b4f430e938115770c82d:42")]
        public bool IncludeDns
        {
            get => _includeDns;
            set
            {
                IncludeDnsSpecified = true;
                _includeDns = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeDnsSpecified { get; set; }

        private bool _includeAccessDevices;

        [XmlElement(ElementName = "includeAccessDevices", IsNullable = false, Namespace = "")]
        [Group(@"5c0fc3a03773b4f430e938115770c82d:42")]
        public bool IncludeAccessDevices
        {
            get => _includeAccessDevices;
            set
            {
                IncludeAccessDevicesSpecified = true;
                _includeAccessDevices = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeAccessDevicesSpecified { get; set; }

        private bool _includeDepartments;

        [XmlElement(ElementName = "includeDepartments", IsNullable = false, Namespace = "")]
        [Group(@"5c0fc3a03773b4f430e938115770c82d:42")]
        public bool IncludeDepartments
        {
            get => _includeDepartments;
            set
            {
                IncludeDepartmentsSpecified = true;
                _includeDepartments = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeDepartmentsSpecified { get; set; }

        private string _reportDeliveryEmailAddress;

        [XmlElement(ElementName = "reportDeliveryEmailAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"5c0fc3a03773b4f430e938115770c82d:42")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ReportDeliveryEmailAddress
        {
            get => _reportDeliveryEmailAddress;
            set
            {
                ReportDeliveryEmailAddressSpecified = true;
                _reportDeliveryEmailAddress = value;
            }
        }

        [XmlIgnore]
        protected bool ReportDeliveryEmailAddressSpecified { get; set; }

    }
}
