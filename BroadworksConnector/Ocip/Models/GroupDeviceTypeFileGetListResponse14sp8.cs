using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupDeviceTypeFileGetListRequest14sp8.
    /// Contains a table of device type files managed by the Device Management System, on a per-group basis.
    /// The column headings are: "File Format", "Is Authenticated", "Access URL", "Repository URL", "Template URL".
    /// 
    /// Replaced by: GroupDeviceTypeFileGetListResponse21
    /// <see cref="GroupDeviceTypeFileGetListRequest14sp8"/>
    /// <see cref="GroupDeviceTypeFileGetListResponse21"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:9354""}]")]
    public class GroupDeviceTypeFileGetListResponse14sp8 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _groupDeviceTypeFilesTable;

        [XmlElement(ElementName = "groupDeviceTypeFilesTable", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:9354")]
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
        protected bool GroupDeviceTypeFilesTableSpecified { get; set; }

    }
}
