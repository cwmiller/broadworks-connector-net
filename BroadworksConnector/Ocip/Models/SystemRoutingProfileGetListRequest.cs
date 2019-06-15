using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of system routing profiles.
    /// 
    /// If resellerId is specified, the routing profiles assigned to the given reseller are returned. If reseller administrator sends the request, resellerId is not specified, the administrator’s resellerId is used.
    /// If system or provisioning administrator sends the request, resellerId is not specified, all system routing profiles are returned.
    /// 
    /// The response is either a SystemRoutingProfileGetListResponse or an ErrorResponse.
        /// <see cref="SystemRoutingProfileGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemRoutingProfileGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _resellerId;

        [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
        public string ResellerId {
            get => _resellerId;
            set {
                ResellerIdSpecified = true;
                _resellerId = value;
            }
        }

        [XmlIgnore]
        public bool ResellerIdSpecified { get; set; }
        
    }
}
