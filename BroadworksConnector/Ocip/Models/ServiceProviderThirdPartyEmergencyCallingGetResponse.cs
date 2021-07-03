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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:6973""}]")]
    public class ServiceProviderThirdPartyEmergencyCallingGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _allowActivation;

        [XmlElement(ElementName = "allowActivation", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:6973")]
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

        private string _customerId;

        [XmlElement(ElementName = "customerId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:6973")]
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

        private bool _hasGroupEnabled;

        [XmlElement(ElementName = "hasGroupEnabled", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:6973")]
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
