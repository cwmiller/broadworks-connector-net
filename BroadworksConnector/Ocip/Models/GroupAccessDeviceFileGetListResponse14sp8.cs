using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupAccessDeviceFileGetListRequest14sp8.
    /// Contains a table of device files managed by the Device Management System on a per-device profile basis.
    /// The column headings are: "File Format", "Is Authenticated", "Access URL", "Repository URL", "Template URL", "Extended Capture".
    /// <see cref="GroupAccessDeviceFileGetListRequest14sp8"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:477""}]")]
    public class GroupAccessDeviceFileGetListResponse14sp8 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _deviceFilesTable;

        [XmlElement(ElementName = "deviceFilesTable", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:477")]
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
        public bool DeviceFilesTableSpecified { get; set; }

    }
}
