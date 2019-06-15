using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the enterprise level data associated with Call Center Agents Unavailable Code Settings.
    /// The response is either an EnterpriseCallCenterAgentUnavailableCodeSettingsGetResponse or an
    /// ErrorResponse.
    /// 
    /// Replaced by EnterpriseCallCenterAgentUnavailableCodeSettingsGetRequest17sp4.
        /// <see cref="EnterpriseCallCenterAgentUnavailableCodeSettingsGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="EnterpriseCallCenterAgentUnavailableCodeSettingsGetRequest17sp4"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class EnterpriseCallCenterAgentUnavailableCodeSettingsGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
