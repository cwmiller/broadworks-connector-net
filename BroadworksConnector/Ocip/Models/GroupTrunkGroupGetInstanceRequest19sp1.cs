using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a Trunk Group Instance's profile.
    /// The response is either a GroupTrunkGroupGetInstanceResponse19sp1 or an ErrorResponse.
    /// The response contains a hosted user table with column headings: "User Id", "Last Name",
    /// "First Name", "Hiragana Last Name", "Hiragana First Name", "Phone Number", "Extension",
    /// "Department", "Email Address".
    /// 
    /// Replaced by GroupTrunkGroupGetInstanceRequest19sp1V2.
    /// <see cref="GroupTrunkGroupGetInstanceResponse19sp1"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="GroupTrunkGroupGetInstanceRequest19sp1V2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:30952""}]")]
    public class GroupTrunkGroupGetInstanceRequest19sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private BroadWorksConnector.Ocip.Models.TrunkGroupKey _trunkGroupKey;

        [XmlElement(ElementName = "trunkGroupKey", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:30952")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupKey TrunkGroupKey
        {
            get => _trunkGroupKey;
            set
            {
                TrunkGroupKeySpecified = true;
                _trunkGroupKey = value;
            }
        }

        [XmlIgnore]
        public bool TrunkGroupKeySpecified { get; set; }

    }
}
