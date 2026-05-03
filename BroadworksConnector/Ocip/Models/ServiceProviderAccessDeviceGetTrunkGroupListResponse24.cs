using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderAccessDeviceGetTrunkGroupListRequest24.
    /// Contains a table of trunk group names associated with the access device, the column headings are:
    /// "Trunk Group Name", "Group ID".
    /// <see cref="ServiceProviderAccessDeviceGetTrunkGroupListRequest24"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:1065""}]")]
    public class ServiceProviderAccessDeviceGetTrunkGroupListResponse24 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _deviceTrunkGroupsTable;

        [XmlElement(ElementName = "deviceTrunkGroupsTable", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:1065")]
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
