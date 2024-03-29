using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemSIPDeviceTypeFileGetListRequest14sp8.
    /// Contains a table of device files managed by the Device Management System on a per-device type basis.
    /// The column headings are: "File Format", "Is Authenticated", "Access URL", "Repository URL", "Template URL".
    /// <see cref="SystemSIPDeviceTypeFileGetListRequest14sp8"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:17217""}]")]
    public class SystemSIPDeviceTypeFileGetListResponse14sp8 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _deviceTypeFilesTable;

        [XmlElement(ElementName = "deviceTypeFilesTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:17217")]
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
        protected bool DeviceTypeFilesTableSpecified { get; set; }

    }
}
