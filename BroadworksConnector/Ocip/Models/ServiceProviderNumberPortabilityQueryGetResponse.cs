using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the ServiceProviderNumberPortabilityQueryGetRequest.
    /// The response contains the service provider number portability query information.
    /// <see cref="ServiceProviderNumberPortabilityQueryGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:5201""}]")]
    public class ServiceProviderNumberPortabilityQueryGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _enableNumberPortabilityQueryForOutgoingCalls;

        [XmlElement(ElementName = "enableNumberPortabilityQueryForOutgoingCalls", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:5201")]
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
        [Group(@"e19a9072c2dad499e9f28837da5768db:5201")]
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
        [Group(@"e19a9072c2dad499e9f28837da5768db:5201")]
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

        protected List<string> _digitPattern = new List<string>();

        [XmlElement(ElementName = "digitPattern", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:5201")]
        [MinLength(1)]
        [MaxLength(160)]
        public List<string> DigitPattern
        {
            get => _digitPattern;
            set
            {
                DigitPatternSpecified = true;
                _digitPattern = value;
            }
        }

        [XmlIgnore]
        protected bool DigitPatternSpecified { get; set; }

    }
}
