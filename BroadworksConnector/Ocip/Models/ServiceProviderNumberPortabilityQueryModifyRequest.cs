using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the Service Provider Number Portability Query information.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:5220""}]")]
    public class ServiceProviderNumberPortabilityQueryModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:5220")]
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

        protected bool _enableNumberPortabilityQueryForOutgoingCalls;

        [XmlElement(ElementName = "enableNumberPortabilityQueryForOutgoingCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:5220")]
        public bool EnableNumberPortabilityQueryForOutgoingCalls
        {
            get => _enableNumberPortabilityQueryForOutgoingCalls;
            set
            {
                EnableNumberPortabilityQueryForOutgoingCallsSpecified = true;
                _enableNumberPortabilityQueryForOutgoingCalls = value;
            }
        }

        [XmlIgnore]
        protected bool EnableNumberPortabilityQueryForOutgoingCallsSpecified { get; set; }

        protected bool _enableNumberPortabilityQueryForIncomingCalls;

        [XmlElement(ElementName = "enableNumberPortabilityQueryForIncomingCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:5220")]
        public bool EnableNumberPortabilityQueryForIncomingCalls
        {
            get => _enableNumberPortabilityQueryForIncomingCalls;
            set
            {
                EnableNumberPortabilityQueryForIncomingCallsSpecified = true;
                _enableNumberPortabilityQueryForIncomingCalls = value;
            }
        }

        [XmlIgnore]
        protected bool EnableNumberPortabilityQueryForIncomingCallsSpecified { get; set; }

        protected bool _enableNumberPortabilityQueryForNetworkCallsOnly;

        [XmlElement(ElementName = "enableNumberPortabilityQueryForNetworkCallsOnly", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:5220")]
        public bool EnableNumberPortabilityQueryForNetworkCallsOnly
        {
            get => _enableNumberPortabilityQueryForNetworkCallsOnly;
            set
            {
                EnableNumberPortabilityQueryForNetworkCallsOnlySpecified = true;
                _enableNumberPortabilityQueryForNetworkCallsOnly = value;
            }
        }

        [XmlIgnore]
        protected bool EnableNumberPortabilityQueryForNetworkCallsOnlySpecified { get; set; }

        protected List<string> _deleteDigitPattern = new List<string>();

        [XmlElement(ElementName = "deleteDigitPattern", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:5220")]
        [MinLength(1)]
        [MaxLength(160)]
        public List<string> DeleteDigitPattern
        {
            get => _deleteDigitPattern;
            set
            {
                DeleteDigitPatternSpecified = true;
                _deleteDigitPattern = value;
            }
        }

        [XmlIgnore]
        protected bool DeleteDigitPatternSpecified { get; set; }

    }
}
