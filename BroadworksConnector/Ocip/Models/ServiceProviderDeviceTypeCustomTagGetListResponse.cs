using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderDeviceTypeCustomTagGetListRequest.
    /// Contains a table of custom configuration tags managed by the Device Management System on a per-device type basis for a service provider.
    /// In As data mode, the column headings are:
    /// "Tag Name", "Tag Value".
    /// In XS data mode, the column headings are:
    /// "Tag Name", "Tag Value" if request is invoked by an admin without system privileges.
    /// "Tag Name", "Tag Value", "Is Encrypted" if request is invoked by an admin with system privileges.
        /// <see cref="ServiceProviderDeviceTypeCustomTagGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderDeviceTypeCustomTagGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _serviceProviderDeviceTypeCustomTagsTable;

        [XmlElement(ElementName = "serviceProviderDeviceTypeCustomTagsTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ServiceProviderDeviceTypeCustomTagsTable {
            get => _serviceProviderDeviceTypeCustomTagsTable;
            set {
                ServiceProviderDeviceTypeCustomTagsTableSpecified = true;
                _serviceProviderDeviceTypeCustomTagsTable = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderDeviceTypeCustomTagsTableSpecified { get; set; }
        
    }
}
