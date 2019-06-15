using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Assigned Group Services List Entry.
    /// The isActive element is true, false, or could be missing completely.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class AssignedGroupServicesEntry 
    {

        
        private BroadWorksConnector.Ocip.Models.GroupService _serviceName;

        [XmlElement(ElementName = "serviceName", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.GroupService ServiceName {
            get => _serviceName;
            set {
                ServiceNameSpecified = true;
                _serviceName = value;
            }
        }

        [XmlIgnore]
        public bool ServiceNameSpecified { get; set; }
        
        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        public bool IsActive {
            get => _isActive;
            set {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        public bool IsActiveSpecified { get; set; }
        
    }
}
