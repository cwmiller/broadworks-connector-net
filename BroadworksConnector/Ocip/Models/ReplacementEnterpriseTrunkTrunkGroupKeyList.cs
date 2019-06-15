using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of Enterprise Trunk Krunk Group Keys that replaces a previously configured list.
    /// By convention, an element of this type may be set nill to clear the list.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ReplacementEnterpriseTrunkTrunkGroupKeyList 
    {

        
        private List<BroadWorksConnector.Ocip.Models.EnterpriseTrunkTrunkGroupKey> _trunkGroupList;

        [XmlElement(ElementName = "trunkGroupList", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.EnterpriseTrunkTrunkGroupKey> TrunkGroupList {
            get => _trunkGroupList;
            set {
                TrunkGroupListSpecified = true;
                _trunkGroupList = value;
            }
        }

        [XmlIgnore]
        public bool TrunkGroupListSpecified { get; set; }
        
    }
}
