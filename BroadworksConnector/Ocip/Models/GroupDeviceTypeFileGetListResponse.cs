using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupDeviceTypeFileGetListRequest.
    /// Contains a table of device type files managed by the Device Management System, on a per-group basis.
    /// The column headings are: "File Type", "File Format", "Is Authenticated".
    /// Replaced By: GroupDeviceTypeFileGetListResponse14sp8
    /// <see cref="GroupDeviceTypeFileGetListRequest"/>
    /// <see cref="GroupDeviceTypeFileGetListResponse14sp8"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:1439""}]")]
    public class GroupDeviceTypeFileGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _groupDeviceTypeFilesTable;

        [XmlElement(ElementName = "groupDeviceTypeFilesTable", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:1439")]
        public BroadWorksConnector.Ocip.Models.C.OCITable GroupDeviceTypeFilesTable
        {
            get => _groupDeviceTypeFilesTable;
            set
            {
                GroupDeviceTypeFilesTableSpecified = true;
                _groupDeviceTypeFilesTable = value;
            }
        }

        [XmlIgnore]
        public bool GroupDeviceTypeFilesTableSpecified { get; set; }

    }
}
