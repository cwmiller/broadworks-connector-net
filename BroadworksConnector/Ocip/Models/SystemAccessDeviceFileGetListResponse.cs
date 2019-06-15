using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemAccessDeviceFileGetListRequest.
    /// Contains a table of device files managed by the Device Management System on a per-device profile basis.
    /// The column headings are: "File Type", "File Format", "Is Authenticated".
    /// Replaced By: SystemAccessDeviceFileGetListResponse14sp8
        /// <see cref="SystemAccessDeviceFileGetListRequest"/>
        /// <see cref="SystemAccessDeviceFileGetListResponse14sp8"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemAccessDeviceFileGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _deviceFilesTable;

        [XmlElement(ElementName = "deviceFilesTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable DeviceFilesTable {
            get => _deviceFilesTable;
            set {
                DeviceFilesTableSpecified = true;
                _deviceFilesTable = value;
            }
        }

        [XmlIgnore]
        public bool DeviceFilesTableSpecified { get; set; }
        
    }
}
