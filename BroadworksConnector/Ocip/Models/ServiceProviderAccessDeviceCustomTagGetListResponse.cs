using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderAccessDeviceCustomTagGetListRequest.
    /// Contains a table of custom configuration tags managed by the Device Management System on a per-device profile basis.
    /// In AS data mode, the column headings are:
    /// "Tag Name", "Tag Value", "Actual Tag Value".
    /// In XS data mode, the column headings are:
    /// "Tag Name", "Tag Value", "Actual Tag Value" if request is invoked by an admin without system privileges.
    /// "Tag Name", "Tag Value", "Is Encrypted", "Actual Tag Value" if request is invoked by an admin with system privileges.
        /// <see cref="ServiceProviderAccessDeviceCustomTagGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderAccessDeviceCustomTagGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _deviceCustomTagsTable;

        [XmlElement(ElementName = "deviceCustomTagsTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable DeviceCustomTagsTable {
            get => _deviceCustomTagsTable;
            set {
                DeviceCustomTagsTableSpecified = true;
                _deviceCustomTagsTable = value;
            }
        }

        [XmlIgnore]
        public bool DeviceCustomTagsTableSpecified { get; set; }
        
    }
}
