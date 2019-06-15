using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the enterprise level data associated with Call Center.
    /// The response is either an EnterpriseCallCenterGetResponse or an
    /// ErrorResponse.
    /// 
    /// Replaced by EnterpriseCallCenterGetRequest17sp4.
        /// <see cref="EnterpriseCallCenterGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="EnterpriseCallCenterGetRequest17sp4"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class EnterpriseCallCenterGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        public string ServiceProviderId {
            get => _serviceProviderId;
            set {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderIdSpecified { get; set; }
        
    }
}
