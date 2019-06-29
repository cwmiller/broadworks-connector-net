using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupTrunkGroupGetInstanceListRequest14.
    /// Contains a table with column headings "Service User Id", "Name", "Department", "Device Name", "Device
    /// Level",
    /// "Group Id".
    /// The "Device Level" column contains one of the AccessDeviceLevel enumerated constants.
    /// <see cref="GroupTrunkGroupGetInstanceListRequest14"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:2360""}]")]
    public class GroupTrunkGroupGetInstanceListResponse14 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _trunkGroupTable;

        [XmlElement(ElementName = "trunkGroupTable", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:2360")]
        public BroadWorksConnector.Ocip.Models.C.OCITable TrunkGroupTable
        {
            get => _trunkGroupTable;
            set
            {
                TrunkGroupTableSpecified = true;
                _trunkGroupTable = value;
            }
        }

        [XmlIgnore]
        protected bool TrunkGroupTableSpecified { get; set; }

    }
}
