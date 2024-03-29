using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the ServiceProviderMWIDeliveryToMobileEndpointCustomTemplateGetRequest.
    /// <see cref="ServiceProviderMWIDeliveryToMobileEndpointCustomTemplateGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1ea80c1e18c25d0eed23dbc7bd18f1dc:265""}]")]
    public class ServiceProviderMWIDeliveryToMobileEndpointCustomTemplateGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _isEnabled;

        [XmlElement(ElementName = "isEnabled", IsNullable = false, Namespace = "")]
        [Group(@"1ea80c1e18c25d0eed23dbc7bd18f1dc:265")]
        public bool IsEnabled
        {
            get => _isEnabled;
            set
            {
                IsEnabledSpecified = true;
                _isEnabled = value;
            }
        }

        [XmlIgnore]
        protected bool IsEnabledSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.MWIDeliveryToMobileEndpointTemplateBody _templateBody;

        [XmlElement(ElementName = "templateBody", IsNullable = false, Namespace = "")]
        [Group(@"1ea80c1e18c25d0eed23dbc7bd18f1dc:265")]
        public BroadWorksConnector.Ocip.Models.MWIDeliveryToMobileEndpointTemplateBody TemplateBody
        {
            get => _templateBody;
            set
            {
                TemplateBodySpecified = true;
                _templateBody = value;
            }
        }

        [XmlIgnore]
        protected bool TemplateBodySpecified { get; set; }

    }
}
