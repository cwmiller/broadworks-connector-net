using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the third-party emergency call service settings for the service provider.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:6991""}]")]
    public class ServiceProviderThirdPartyEmergencyCallingModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:6991")]
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

        private bool _allowActivation;

        [XmlElement(ElementName = "allowActivation", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:6991")]
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

        [XmlElement(ElementName = "customerId", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:6991")]
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

    }
}
