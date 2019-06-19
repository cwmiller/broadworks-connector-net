using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Create a MWI Delivery to Mobile Endpoint Custom Template.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""958b78cc2a785d78259c1e8a474eb40d:55""}]")]
    public class GroupMWIDeliveryToMobileEndpointCustomTemplateAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"958b78cc2a785d78259c1e8a474eb40d:55")]
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
        public bool ServiceProviderIdSpecified { get; set; }

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"958b78cc2a785d78259c1e8a474eb40d:55")]
        [MinLength(1)]
        [MaxLength(30)]
        public string GroupId
        {
            get => _groupId;
            set
            {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        public bool GroupIdSpecified { get; set; }

        private string _language;

        [XmlElement(ElementName = "language", IsNullable = false, Namespace = "")]
        [Group(@"958b78cc2a785d78259c1e8a474eb40d:55")]
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
        public bool LanguageSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.MWIDeliveryToMobileEndpointTemplateType _type;

        [XmlElement(ElementName = "type", IsNullable = false, Namespace = "")]
        [Group(@"958b78cc2a785d78259c1e8a474eb40d:55")]
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
        public bool TypeSpecified { get; set; }

        private bool _isEnabled;

        [XmlElement(ElementName = "isEnabled", IsNullable = false, Namespace = "")]
        [Group(@"958b78cc2a785d78259c1e8a474eb40d:55")]
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
        public bool IsEnabledSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.MWIDeliveryToMobileEndpointTemplateBody _templateBody;

        [XmlElement(ElementName = "templateBody", IsNullable = false, Namespace = "")]
        [Group(@"958b78cc2a785d78259c1e8a474eb40d:55")]
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
        public bool TemplateBodySpecified { get; set; }

    }
}
