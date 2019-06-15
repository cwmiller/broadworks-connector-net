using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the EnterpriseCallCenterCurrentAndPastCallCenterGetListRequest.
        /// <see cref="EnterpriseCallCenterCurrentAndPastCallCenterGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class EnterpriseCallCenterCurrentAndPastCallCenterGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private List<string> _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        public List<string> ServiceUserId {
            get => _serviceUserId;
            set {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceUserIdSpecified { get; set; }
        
        private List<string> _deletedServiceUserId;

        [XmlElement(ElementName = "deletedServiceUserId", IsNullable = false, Namespace = "")]
        public List<string> DeletedServiceUserId {
            get => _deletedServiceUserId;
            set {
                DeletedServiceUserIdSpecified = true;
                _deletedServiceUserId = value;
            }
        }

        [XmlIgnore]
        public bool DeletedServiceUserIdSpecified { get; set; }
        
    }
}
