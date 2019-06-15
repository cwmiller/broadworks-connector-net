using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a Trunk Group Instance's profile.
    /// The response is either a GroupTrunkGroupGetInstanceResponse17sp3 or an ErrorResponse.
    /// The response contains a hosted user table with column headings: "User Id", "Last Name",
    /// "First Name", "Hiragana Last Name", "Hiragana First Name".
    /// 
    /// Replaced by: GroupTrunkGroupGetInstanceRequest17sp4
        /// <see cref="GroupTrunkGroupGetInstanceResponse17sp3"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="GroupTrunkGroupGetInstanceRequest17sp4"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupTrunkGroupGetInstanceRequest17sp3 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private BroadWorksConnector.Ocip.Models.TrunkGroupKey _trunkGroupKey;

        [XmlElement(ElementName = "trunkGroupKey", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupKey TrunkGroupKey {
            get => _trunkGroupKey;
            set {
                TrunkGroupKeySpecified = true;
                _trunkGroupKey = value;
            }
        }

        [XmlIgnore]
        public bool TrunkGroupKeySpecified { get; set; }
        
    }
}
