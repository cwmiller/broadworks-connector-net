using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupTrunkGroupGetInstanceListRequest14sp4.
    /// Contains a table with column headings "Name", "Department", "Device Name", "Device Level",
    /// "Group Id".
    /// The "Device Level" column contains one of the AccessDeviceLevel enumerated constants.
    /// <see cref="GroupTrunkGroupGetInstanceListRequest14sp4"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b9c14e2d80e4e7749688ca13ba233b44:1115""}]")]
    public class GroupTrunkGroupGetInstanceListResponse14sp4 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _trunkGroupTable;

        [XmlElement(ElementName = "trunkGroupTable", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1115")]
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
