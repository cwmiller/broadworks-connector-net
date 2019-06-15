using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a call center's bounced call settings.
    /// The response is either a GroupCallCenterBouncedCallGetResponse or an ErrorResponse.
    /// 
    /// Replaced by: GroupCallCenterBouncedCallGetRequest17
        /// <see cref="GroupCallCenterBouncedCallGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="GroupCallCenterBouncedCallGetRequest17"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupCallCenterBouncedCallGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
