using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get all the information of a BroadWorks Anywhere instance.
    /// The response is either GroupBroadWorksAnywhereGetInstanceResponse17 or ErrorResponse.
    /// 
    /// Replaced by: GroupBroadWorksAnywhereGetInstanceRequest19sp1 in AS data mode
        /// <see cref="GroupBroadWorksAnywhereGetInstanceResponse17"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="GroupBroadWorksAnywhereGetInstanceRequest19sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupBroadWorksAnywhereGetInstanceRequest17 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        public string ServiceUserId {
            get => _serviceUserId;
            set {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceUserIdSpecified { get; set; }
        
    }
}
