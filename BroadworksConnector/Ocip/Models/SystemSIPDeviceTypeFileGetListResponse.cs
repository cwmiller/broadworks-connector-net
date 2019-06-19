using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemSIPDeviceTypeFileGetListRequest.
    /// Contains a table of device files managed by the Device Management System on a per-device type basis.
    /// The column headings are: "File Type", "File Format", "Is Authenticated".
    /// Replaced By: SystemSIPDeviceTypeFileGetListResponse14sp8
    /// <see cref="SystemSIPDeviceTypeFileGetListRequest"/>
    /// <see cref="SystemSIPDeviceTypeFileGetListResponse14sp8"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:6004""}]")]
    public class SystemSIPDeviceTypeFileGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _deviceTypeFilesTable;

        [XmlElement(ElementName = "deviceTypeFilesTable", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6004")]
        public BroadWorksConnector.Ocip.Models.C.OCITable DeviceTypeFilesTable
        {
            get => _deviceTypeFilesTable;
            set
            {
                DeviceTypeFilesTableSpecified = true;
                _deviceTypeFilesTable = value;
            }
        }

        [XmlIgnore]
        public bool DeviceTypeFilesTableSpecified { get; set; }

    }
}
