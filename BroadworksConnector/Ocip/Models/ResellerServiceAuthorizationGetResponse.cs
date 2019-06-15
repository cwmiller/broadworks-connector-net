using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the ResellerServiceAuthorizationGetRequest.
        /// <see cref="ResellerServiceAuthorizationGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ResellerServiceAuthorizationGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private string _serviceOffering;

        [XmlElement(ElementName = "serviceOffering", IsNullable = false, Namespace = "")]
        public string ServiceOffering {
            get => _serviceOffering;
            set {
                ServiceOfferingSpecified = true;
                _serviceOffering = value;
            }
        }

        [XmlIgnore]
        public bool ServiceOfferingSpecified { get; set; }
        
    }
}
