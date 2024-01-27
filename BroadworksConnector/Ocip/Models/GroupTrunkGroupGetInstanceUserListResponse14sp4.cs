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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""090e91b2d78e873f5d76a2f16af08d3a:1286""}]")]
    public class GroupTrunkGroupGetInstanceUserListResponse14sp4 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _trunkGroupUserTable;

        [XmlElement(ElementName = "trunkGroupUserTable", IsNullable = false, Namespace = "")]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:1286")]
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
        protected bool TrunkGroupUserTableSpecified { get; set; }

    }
}
