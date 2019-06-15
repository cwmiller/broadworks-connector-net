using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get all the information of a Group Paging instance.
    /// The response is either GroupGroupPagingGetInstanceResponse17sp3 or ErrorResponse.
    /// 
    /// Replaced by: GroupGroupPagingGetInstanceRequest19sp1
        /// <see cref="GroupGroupPagingGetInstanceResponse17sp3"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="GroupGroupPagingGetInstanceRequest19sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupGroupPagingGetInstanceRequest17sp3 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
