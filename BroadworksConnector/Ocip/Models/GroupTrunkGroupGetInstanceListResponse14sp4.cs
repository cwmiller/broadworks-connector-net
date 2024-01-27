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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""090e91b2d78e873f5d76a2f16af08d3a:1134""}]")]
    public class GroupTrunkGroupGetInstanceListResponse14sp4 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _trunkGroupTable;

        [XmlElement(ElementName = "trunkGroupTable", IsNullable = false, Namespace = "")]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:1134")]
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
