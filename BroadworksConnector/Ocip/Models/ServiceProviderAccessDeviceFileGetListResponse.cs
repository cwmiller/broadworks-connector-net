using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderAccessDeviceFileGetListRequest.
    /// Contains a table of device files managed by the Device Management System on a per-device profile basis.
    /// The column headings are: "File Type", "File Format", "Is Authenticated".
    /// Replaced By: ServiceProviderAccessDeviceFileGetListResponse14sp8
    /// <see cref="ServiceProviderAccessDeviceFileGetListRequest"/>
    /// <see cref="ServiceProviderAccessDeviceFileGetListResponse14sp8"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:16601""}]")]
    public class ServiceProviderAccessDeviceFileGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _deviceFilesTable;

        [XmlElement(ElementName = "deviceFilesTable", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:16601")]
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
