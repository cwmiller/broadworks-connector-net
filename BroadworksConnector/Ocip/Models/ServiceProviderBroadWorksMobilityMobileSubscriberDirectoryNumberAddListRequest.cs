using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Adds Mobile Subscriber Directory Numbers to a service provider. It is possible to add a single DN,
    /// or a list of DNs.
    /// The response is either SuccessResponse or ErrorResponse.
    /// Replaced by ServiceProviderBroadWorksMobilityMobileSubscriberDirectoryNumberAddListRequest21.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="ServiceProviderBroadWorksMobilityMobileSubscriberDirectoryNumberAddListRequest21"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderBroadWorksMobilityMobileSubscriberDirectoryNumberAddListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private List<string> _mobileSubscriberDirectoryNumber;

        [XmlElement(ElementName = "mobileSubscriberDirectoryNumber", IsNullable = false, Namespace = "")]
        public List<string> MobileSubscriberDirectoryNumber {
            get => _mobileSubscriberDirectoryNumber;
            set {
                MobileSubscriberDirectoryNumberSpecified = true;
                _mobileSubscriberDirectoryNumber = value;
            }
        }

        [XmlIgnore]
        public bool MobileSubscriberDirectoryNumberSpecified { get; set; }
        
    }
}
