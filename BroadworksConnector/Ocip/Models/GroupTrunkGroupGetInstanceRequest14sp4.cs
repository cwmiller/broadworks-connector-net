using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a Trunk Group Instance's profile.
    /// The response is either a GroupTrunkGroupGetInstanceResponse14sp4 or an ErrorResponse.
        /// <see cref="GroupTrunkGroupGetInstanceResponse14sp4"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupTrunkGroupGetInstanceRequest14sp4 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
