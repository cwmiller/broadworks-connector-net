using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Returns true if the UserService or service pack is assigned, otherwise false.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserServiceIsAssignedResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private bool _isAssigned;

        [XmlElement(ElementName = "isAssigned", IsNullable = false, Namespace = "")]
        public bool IsAssigned {
            get => _isAssigned;
            set {
                IsAssignedSpecified = true;
                _isAssigned = value;
            }
        }

        [XmlIgnore]
        public bool IsAssignedSpecified { get; set; }
        
    }
}
