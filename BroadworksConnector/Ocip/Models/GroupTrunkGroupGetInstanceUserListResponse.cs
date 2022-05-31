using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupTrunkGroupGetInstanceUserListRequest.
    /// The response contains a 7 column table with column headings "User Id", "Last Name",
    /// "First Name", "Department", "Phone Number", "Hiragana Last Name", "Hiragana First Name".
    /// <see cref="GroupTrunkGroupGetInstanceUserListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:15507""}]")]
    public class GroupTrunkGroupGetInstanceUserListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _trunkGroupUserTable;

        [XmlElement(ElementName = "trunkGroupUserTable", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15507")]
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
