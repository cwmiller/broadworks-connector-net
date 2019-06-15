using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Delete originator(s) from a paging group.
    /// The response is either SuccessResponse or ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupGroupPagingDeleteOriginatorListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private List<string> _originatorUserId;

        [XmlElement(ElementName = "originatorUserId", IsNullable = false, Namespace = "")]
        public List<string> OriginatorUserId {
            get => _originatorUserId;
            set {
                OriginatorUserIdSpecified = true;
                _originatorUserId = value;
            }
        }

        [XmlIgnore]
        public bool OriginatorUserIdSpecified { get; set; }
        
    }
}
