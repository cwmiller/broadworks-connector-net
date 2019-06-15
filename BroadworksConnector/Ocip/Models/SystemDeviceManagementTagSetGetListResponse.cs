using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemDeviceManagementTagSetGetListRequest.
    /// The response includes an array of tag set names defined in the system.
    /// The system default tag set name is not part of this response.
    /// 
    /// Replaced by SystemDeviceManagementTagSetGetListResponse22 in AS data mode
        /// <see cref="SystemDeviceManagementTagSetGetListRequest"/>
        /// <see cref="SystemDeviceManagementTagSetGetListResponse22"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemDeviceManagementTagSetGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private List<string> _tagSetName;

        [XmlElement(ElementName = "tagSetName", IsNullable = false, Namespace = "")]
        public List<string> TagSetName {
            get => _tagSetName;
            set {
                TagSetNameSpecified = true;
                _tagSetName = value;
            }
        }

        [XmlIgnore]
        public bool TagSetNameSpecified { get; set; }
        
    }
}
