using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get all the information of an Instant Group Call service instance.
    /// The response is either GroupInstantGroupCallGetInstanceResponse17 or ErrorResponse.
    /// 
    /// Replaced by: GroupInstantGroupCallGetInstanceRequest19sp1
        /// <see cref="GroupInstantGroupCallGetInstanceResponse17"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="GroupInstantGroupCallGetInstanceRequest19sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupInstantGroupCallGetInstanceRequest17 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
