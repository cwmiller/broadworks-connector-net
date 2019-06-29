using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderAccessDeviceFileGetListRequest14sp8.
    /// Contains a table of device files managed by the Device Management System on a per-device profile basis.
    /// The column headings are: "File Format", "Is Authenticated", "Access URL", "Repository URL", "Template URL", "Extended Capture".
    /// <see cref="ServiceProviderAccessDeviceFileGetListRequest14sp8"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:402""}]")]
    public class ServiceProviderAccessDeviceFileGetListResponse14sp8 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _deviceFilesTable;

        [XmlElement(ElementName = "deviceFilesTable", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:402")]
        public BroadWorksConnector.Ocip.Models.C.OCITable DeviceFilesTable
        {
            get => _deviceFilesTable;
            set
            {
                DeviceFilesTableSpecified = true;
                _deviceFilesTable = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceFilesTableSpecified { get; set; }

    }
}
