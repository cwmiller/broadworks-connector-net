using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemAccessDeviceFileGetListRequest14sp8.
    /// Contains a table of device files managed by the Device Management System on a per-device profile basis.
    /// The column headings are: "File Format", "Is Authenticated", "Access URL", "Repository URL", "Template URL", "Extended Capture URL", "Is File Linked".
    /// 
    /// The following column is only populated in AS data mode for leaf devices.
    /// "Is File Linked"
    /// <see cref="SystemAccessDeviceFileGetListRequest14sp8"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:973""}]")]
    public class SystemAccessDeviceFileGetListResponse14sp8 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _deviceFilesTable;

        [XmlElement(ElementName = "deviceFilesTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:973")]
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
