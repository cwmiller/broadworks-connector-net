using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupCustomContactDirectoryGetListRequest.
    /// The response contains all the group's custom contact directory names.
        /// <see cref="GroupCustomContactDirectoryGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupCustomContactDirectoryGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private List<string> _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        public List<string> Name {
            get => _name;
            set {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        public bool NameSpecified { get; set; }
        
    }
}
