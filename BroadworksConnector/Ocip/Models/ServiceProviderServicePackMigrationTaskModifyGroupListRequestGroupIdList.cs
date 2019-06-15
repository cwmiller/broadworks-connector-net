using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// 
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderServicePackMigrationTaskModifyGroupListRequestGroupIdList 
    {

        
        private List<string> _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        public List<string> GroupId {
            get => _groupId;
            set {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        public bool GroupIdSpecified { get; set; }
        
    }
}
