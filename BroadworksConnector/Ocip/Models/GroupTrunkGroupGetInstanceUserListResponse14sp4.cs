using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupTrunkGroupGetInstanceUserListRequest14sp4.
    /// The response contains a 9 column table with column headings "User Id", "Last Name",
    /// "First Name", "Department", "Phone Number", "Hiragana Last Name", "Hiragana First Name",
    /// "Extension", "Email Address".
    /// <see cref="GroupTrunkGroupGetInstanceUserListRequest14sp4"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b9c14e2d80e4e7749688ca13ba233b44:1267""}]")]
    public class GroupTrunkGroupGetInstanceUserListResponse14sp4 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _trunkGroupUserTable;

        [XmlElement(ElementName = "trunkGroupUserTable", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1267")]
        public BroadWorksConnector.Ocip.Models.C.OCITable TrunkGroupUserTable
        {
            get => _trunkGroupUserTable;
            set
            {
                TrunkGroupUserTableSpecified = true;
                _trunkGroupUserTable = value;
            }
        }

        [XmlIgnore]
        public bool TrunkGroupUserTableSpecified { get; set; }

    }
}
