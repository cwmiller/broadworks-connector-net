using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of Call Center Level and Organization Level Call Disposition Codes.
    /// The response is either GroupCallCenterQueueCallDispositionCodeGetListResponse or ErrorResponse.
        /// <see cref="GroupCallCenterQueueCallDispositionCodeGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupCallCenterQueueCallDispositionCodeGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
