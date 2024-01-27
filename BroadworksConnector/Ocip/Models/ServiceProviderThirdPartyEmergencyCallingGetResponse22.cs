using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the ServiceProviderThirdPartyEmergencyCallingGetRequest22.
    /// The response contains the third-party emergency call service settings for the service provider.
    /// <see cref="ServiceProviderThirdPartyEmergencyCallingGetRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:7049""}]")]
    public class ServiceProviderThirdPartyEmergencyCallingGetResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _allowActivation;

        [XmlElement(ElementName = "allowActivation", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:7049")]
        public bool AllowActivation
        {
            get => _allowActivation;
            set
            {
                AllowActivationSpecified = true;
                _allowActivation = value;
            }
        }

        [XmlIgnore]
        protected bool AllowActivationSpecified { get; set; }

        protected string _customerId;

        [XmlElement(ElementName = "customerId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:7049")]
        [MinLength(1)]
        [MaxLength(36)]
        public string CustomerId
        {
            get => _customerId;
            set
            {
                CustomerIdSpecified = true;
                _customerId = value;
            }
        }

        [XmlIgnore]
        protected bool CustomerIdSpecified { get; set; }

        protected bool _hasGroupEnabled;

        [XmlElement(ElementName = "hasGroupEnabled", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:7049")]
        public bool HasGroupEnabled
        {
            get => _hasGroupEnabled;
            set
            {
                HasGroupEnabledSpecified = true;
                _hasGroupEnabled = value;
            }
        }

        [XmlIgnore]
        protected bool HasGroupEnabledSpecified { get; set; }

        protected string _secretKey;

        [XmlElement(ElementName = "secretKey", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:7049")]
        [MinLength(1)]
        [MaxLength(16)]
        public string SecretKey
        {
            get => _secretKey;
            set
            {
                SecretKeySpecified = true;
                _secretKey = value;
            }
        }

        [XmlIgnore]
        protected bool SecretKeySpecified { get; set; }

    }
}
