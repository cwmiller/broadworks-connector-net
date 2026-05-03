using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupAccessDeviceGetTrunkGroupListRequest24.
    /// Contains a table of trunk group names associated with the access device,
    /// the column headings are: "Trunk Group Name".
    /// <see cref="GroupAccessDeviceGetTrunkGroupListRequest24"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:1194""}]")]
    public class GroupAccessDeviceGetTrunkGroupListResponse24 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _deviceTrunkGroupsTable;

        [XmlElement(ElementName = "deviceTrunkGroupsTable", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:1194")]
        public BroadWorksConnector.Ocip.Models.C.OCITable DeviceTrunkGroupsTable
        {
            get => _deviceTrunkGroupsTable;
            set
            {
                DeviceTrunkGroupsTableSpecified = true;
                _deviceTrunkGroupsTable = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceTrunkGroupsTableSpecified { get; set; }

    }
}
