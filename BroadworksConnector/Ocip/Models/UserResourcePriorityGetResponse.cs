using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserResourcePriorityGetRequest.
    /// Contains the Resource Priority settings of a user.
    /// If useDefaultResourcePriority is true, parameter resourcePriority will not be returned.
        /// <see cref="UserResourcePriorityGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserResourcePriorityGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private bool _useDefaultResourcePriority;

        [XmlElement(ElementName = "useDefaultResourcePriority", IsNullable = false, Namespace = "")]
        public bool UseDefaultResourcePriority {
            get => _useDefaultResourcePriority;
            set {
                UseDefaultResourcePrioritySpecified = true;
                _useDefaultResourcePriority = value;
            }
        }

        [XmlIgnore]
        public bool UseDefaultResourcePrioritySpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ResourcePriorityValue _defaultResourcePriority;

        [XmlElement(ElementName = "defaultResourcePriority", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ResourcePriorityValue DefaultResourcePriority {
            get => _defaultResourcePriority;
            set {
                DefaultResourcePrioritySpecified = true;
                _defaultResourcePriority = value;
            }
        }

        [XmlIgnore]
        public bool DefaultResourcePrioritySpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ResourcePriorityValue _userResourcePriority;

        [XmlElement(ElementName = "userResourcePriority", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ResourcePriorityValue UserResourcePriority {
            get => _userResourcePriority;
            set {
                UserResourcePrioritySpecified = true;
                _userResourcePriority = value;
            }
        }

        [XmlIgnore]
        public bool UserResourcePrioritySpecified { get; set; }
        
    }
}
