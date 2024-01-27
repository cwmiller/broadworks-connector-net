using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the ServiceProviderThirdPartyEmergencyCallingGetRequest.
    /// The response contains the third-party emergency call service settings for the service provider.
    /// <see cref="ServiceProviderThirdPartyEmergencyCallingGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:19809""}]")]
    public class ServiceProviderThirdPartyEmergencyCallingGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _allowActivation;

        [XmlElement(ElementName = "allowActivation", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:19809")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:19809")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:19809")]
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

    }
}
