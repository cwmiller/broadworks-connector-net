using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request a MWI Delivery to Mobile Endpoint Custom Template.
    /// The response is either a ServiceProviderMWIDeliveryToMobileEndpointCustomTemplateGetResponse or an ErrorResponse.
    /// <see cref="ServiceProviderMWIDeliveryToMobileEndpointCustomTemplateGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1ea80c1e18c25d0eed23dbc7bd18f1dc:248""}]")]
    public class ServiceProviderMWIDeliveryToMobileEndpointCustomTemplateGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.ServiceProviderMWIDeliveryToMobileEndpointCustomTemplateGetResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"1ea80c1e18c25d0eed23dbc7bd18f1dc:248")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }

        protected string _language;

        [XmlElement(ElementName = "language", IsNullable = false, Namespace = "")]
        [Group(@"1ea80c1e18c25d0eed23dbc7bd18f1dc:248")]
        [MinLength(1)]
        [MaxLength(40)]
        public string Language
        {
            get => _language;
            set
            {
                LanguageSpecified = true;
                _language = value;
            }
        }

        [XmlIgnore]
        protected bool LanguageSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.MWIDeliveryToMobileEndpointTemplateType _type;

        [XmlElement(ElementName = "type", IsNullable = false, Namespace = "")]
        [Group(@"1ea80c1e18c25d0eed23dbc7bd18f1dc:248")]
        public BroadWorksConnector.Ocip.Models.MWIDeliveryToMobileEndpointTemplateType Type
        {
            get => _type;
            set
            {
                TypeSpecified = true;
                _type = value;
            }
        }

        [XmlIgnore]
        protected bool TypeSpecified { get; set; }

    }
}
