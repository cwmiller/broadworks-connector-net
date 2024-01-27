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
    /// The column headings are: "File Format", "Is Authenticated", "Access URL", "Repository URL", "Template URL", "Extended Capture URL", "Is File Linked".
    /// 
    /// The following column is only populated in AS data mode for leaf devices.
    /// "Is File Linked"
    /// <see cref="ServiceProviderAccessDeviceFileGetListRequest14sp8"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:534""}]")]
    public class ServiceProviderAccessDeviceFileGetListResponse14sp8 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _deviceFilesTable;

        [XmlElement(ElementName = "deviceFilesTable", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:534")]
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
