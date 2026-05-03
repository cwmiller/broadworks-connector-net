using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemAccessDeviceGetTrunkGroupListRequest24.
    /// Contains a table of trunk group names associated with the access device, the column headings are:
    /// "Trunk Group Name", "Service Provider ID", "Group ID".
    /// <see cref="SystemAccessDeviceGetTrunkGroupListRequest24"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:1482""}]")]
    public class SystemAccessDeviceGetTrunkGroupListResponse24 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _deviceTrunkGroupsTable;

        [XmlElement(ElementName = "deviceTrunkGroupsTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:1482")]
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
