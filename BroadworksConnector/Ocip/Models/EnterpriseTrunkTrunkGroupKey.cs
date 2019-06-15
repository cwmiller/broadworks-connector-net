using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Identifies a trunk group within an Enterprise Trunk where the service provider id is already known.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class EnterpriseTrunkTrunkGroupKey 
    {

        
        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        public string GroupId {
            get => _groupId;
            set {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        public bool GroupIdSpecified { get; set; }
        
        private string _trunkGroupName;

        [XmlElement(ElementName = "trunkGroupName", IsNullable = false, Namespace = "")]
        public string TrunkGroupName {
            get => _trunkGroupName;
            set {
                TrunkGroupNameSpecified = true;
                _trunkGroupName = value;
            }
        }

        [XmlIgnore]
        public bool TrunkGroupNameSpecified { get; set; }
        
    }
}
