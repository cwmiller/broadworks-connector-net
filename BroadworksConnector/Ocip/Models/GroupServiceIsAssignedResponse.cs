using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Returns true if the GroupService is assigned, otherwise false.
    /// Response to GroupServiceIsAssignedRequest
        /// <see cref="GroupServiceIsAssignedRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupServiceIsAssignedResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
