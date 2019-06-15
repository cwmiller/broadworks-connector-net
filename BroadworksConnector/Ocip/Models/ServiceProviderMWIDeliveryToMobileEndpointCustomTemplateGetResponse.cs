using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the ServiceProviderMWIDeliveryToMobileEndpointCustomTemplateGetRequest.
        /// <see cref="ServiceProviderMWIDeliveryToMobileEndpointCustomTemplateGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderMWIDeliveryToMobileEndpointCustomTemplateGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private bool _isEnabled;

        [XmlElement(ElementName = "isEnabled", IsNullable = false, Namespace = "")]
        public bool IsEnabled {
            get => _isEnabled;
            set {
                IsEnabledSpecified = true;
                _isEnabled = value;
            }
        }

        [XmlIgnore]
        public bool IsEnabledSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.MWIDeliveryToMobileEndpointTemplateBody _templateBody;

        [XmlElement(ElementName = "templateBody", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.MWIDeliveryToMobileEndpointTemplateBody TemplateBody {
            get => _templateBody;
            set {
                TemplateBodySpecified = true;
                _templateBody = value;
            }
        }

        [XmlIgnore]
        public bool TemplateBodySpecified { get; set; }
        
    }
}
