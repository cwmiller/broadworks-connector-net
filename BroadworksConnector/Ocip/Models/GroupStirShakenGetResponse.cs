using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupStirShakenGetRequest.
    /// <see cref="GroupStirShakenGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:8316""}]")]
    public class GroupStirShakenGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _useParentLevelSettings;

        [XmlElement(ElementName = "useParentLevelSettings", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:8316")]
        public bool UseParentLevelSettings
        {
            get => _useParentLevelSettings;
            set
            {
                UseParentLevelSettingsSpecified = true;
                _useParentLevelSettings = value;
            }
        }

        [XmlIgnore]
        protected bool UseParentLevelSettingsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.StirShakenSigningPolicy _signingPolicy;

        [XmlElement(ElementName = "signingPolicy", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:8316")]
        public BroadWorksConnector.Ocip.Models.StirShakenSigningPolicy SigningPolicy
        {
            get => _signingPolicy;
            set
            {
                SigningPolicySpecified = true;
                _signingPolicy = value;
            }
        }

        [XmlIgnore]
        protected bool SigningPolicySpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.StirShakenTaggingPolicy _taggingPolicy;

        [XmlElement(ElementName = "taggingPolicy", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:8316")]
        public BroadWorksConnector.Ocip.Models.StirShakenTaggingPolicy TaggingPolicy
        {
            get => _taggingPolicy;
            set
            {
                TaggingPolicySpecified = true;
                _taggingPolicy = value;
            }
        }

        [XmlIgnore]
        protected bool TaggingPolicySpecified { get; set; }

        protected string _signingServiceURL;

        [XmlElement(ElementName = "signingServiceURL", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:8316")]
        [MinLength(1)]
        [MaxLength(256)]
        public string SigningServiceURL
        {
            get => _signingServiceURL;
            set
            {
                SigningServiceURLSpecified = true;
                _signingServiceURL = value;
            }
        }

        [XmlIgnore]
        protected bool SigningServiceURLSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.StirShakenTagFromOrPAI _tagFromOrPAI;

        [XmlElement(ElementName = "tagFromOrPAI", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:8316")]
        public BroadWorksConnector.Ocip.Models.StirShakenTagFromOrPAI TagFromOrPAI
        {
            get => _tagFromOrPAI;
            set
            {
                TagFromOrPAISpecified = true;
                _tagFromOrPAI = value;
            }
        }

        [XmlIgnore]
        protected bool TagFromOrPAISpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.StirShakenVerstatTag _verstatTag;

        [XmlElement(ElementName = "verstatTag", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:8316")]
        public BroadWorksConnector.Ocip.Models.StirShakenVerstatTag VerstatTag
        {
            get => _verstatTag;
            set
            {
                VerstatTagSpecified = true;
                _verstatTag = value;
            }
        }

        [XmlIgnore]
        protected bool VerstatTagSpecified { get; set; }

        protected bool _useOSValueForOrigId;

        [XmlElement(ElementName = "useOSValueForOrigId", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:8316")]
        public bool UseOSValueForOrigId
        {
            get => _useOSValueForOrigId;
            set
            {
                UseOSValueForOrigIdSpecified = true;
                _useOSValueForOrigId = value;
            }
        }

        [XmlIgnore]
        protected bool UseOSValueForOrigIdSpecified { get; set; }

        protected string _origUUID;

        [XmlElement(ElementName = "origUUID", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:8316")]
        [MaxLength(36)]
        public string OrigUUID
        {
            get => _origUUID;
            set
            {
                OrigUUIDSpecified = true;
                _origUUID = value;
            }
        }

        [XmlIgnore]
        protected bool OrigUUIDSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.StirShakenAttestationLevel _attestationLevel;

        [XmlElement(ElementName = "attestationLevel", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:8316")]
        public BroadWorksConnector.Ocip.Models.StirShakenAttestationLevel AttestationLevel
        {
            get => _attestationLevel;
            set
            {
                AttestationLevelSpecified = true;
                _attestationLevel = value;
            }
        }

        [XmlIgnore]
        protected bool AttestationLevelSpecified { get; set; }

        protected bool _enableVerification;

        [XmlElement(ElementName = "enableVerification", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:8316")]
        public bool EnableVerification
        {
            get => _enableVerification;
            set
            {
                EnableVerificationSpecified = true;
                _enableVerification = value;
            }
        }

        [XmlIgnore]
        protected bool EnableVerificationSpecified { get; set; }

        protected string _verificationServiceURL;

        [XmlElement(ElementName = "verificationServiceURL", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:8316")]
        [MinLength(1)]
        [MaxLength(256)]
        public string VerificationServiceURL
        {
            get => _verificationServiceURL;
            set
            {
                VerificationServiceURLSpecified = true;
                _verificationServiceURL = value;
            }
        }

        [XmlIgnore]
        protected bool VerificationServiceURLSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.StirShakenVerificationErrorHandling _verificationErrorHandling;

        [XmlElement(ElementName = "verificationErrorHandling", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:8316")]
        public BroadWorksConnector.Ocip.Models.StirShakenVerificationErrorHandling VerificationErrorHandling
        {
            get => _verificationErrorHandling;
            set
            {
                VerificationErrorHandlingSpecified = true;
                _verificationErrorHandling = value;
            }
        }

        [XmlIgnore]
        protected bool VerificationErrorHandlingSpecified { get; set; }

        protected bool _proxyVerstatToCNAMSubscribe;

        [XmlElement(ElementName = "proxyVerstatToCNAMSubscribe", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:8316")]
        public bool ProxyVerstatToCNAMSubscribe
        {
            get => _proxyVerstatToCNAMSubscribe;
            set
            {
                ProxyVerstatToCNAMSubscribeSpecified = true;
                _proxyVerstatToCNAMSubscribe = value;
            }
        }

        [XmlIgnore]
        protected bool ProxyVerstatToCNAMSubscribeSpecified { get; set; }

        protected bool _useUnknownHeadersFromCNAMNotify;

        [XmlElement(ElementName = "useUnknownHeadersFromCNAMNotify", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:8316")]
        public bool UseUnknownHeadersFromCNAMNotify
        {
            get => _useUnknownHeadersFromCNAMNotify;
            set
            {
                UseUnknownHeadersFromCNAMNotifySpecified = true;
                _useUnknownHeadersFromCNAMNotify = value;
            }
        }

        [XmlIgnore]
        protected bool UseUnknownHeadersFromCNAMNotifySpecified { get; set; }

        protected bool _enableSigningForUnscreenedTrunkGroupOriginations;

        [XmlElement(ElementName = "enableSigningForUnscreenedTrunkGroupOriginations", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:8316")]
        public bool EnableSigningForUnscreenedTrunkGroupOriginations
        {
            get => _enableSigningForUnscreenedTrunkGroupOriginations;
            set
            {
                EnableSigningForUnscreenedTrunkGroupOriginationsSpecified = true;
                _enableSigningForUnscreenedTrunkGroupOriginations = value;
            }
        }

        [XmlIgnore]
        protected bool EnableSigningForUnscreenedTrunkGroupOriginationsSpecified { get; set; }

        protected bool _enableTaggingForUnscreenedTrunkGroupOriginations;

        [XmlElement(ElementName = "enableTaggingForUnscreenedTrunkGroupOriginations", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:8316")]
        public bool EnableTaggingForUnscreenedTrunkGroupOriginations
        {
            get => _enableTaggingForUnscreenedTrunkGroupOriginations;
            set
            {
                EnableTaggingForUnscreenedTrunkGroupOriginationsSpecified = true;
                _enableTaggingForUnscreenedTrunkGroupOriginations = value;
            }
        }

        [XmlIgnore]
        protected bool EnableTaggingForUnscreenedTrunkGroupOriginationsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.StirShakenUnscreenedTrunkGroupOriginationAttestationLevel _unscreenedTrunkGroupOriginationAttestationLevel;

        [XmlElement(ElementName = "unscreenedTrunkGroupOriginationAttestationLevel", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:8316")]
        public BroadWorksConnector.Ocip.Models.StirShakenUnscreenedTrunkGroupOriginationAttestationLevel UnscreenedTrunkGroupOriginationAttestationLevel
        {
            get => _unscreenedTrunkGroupOriginationAttestationLevel;
            set
            {
                UnscreenedTrunkGroupOriginationAttestationLevelSpecified = true;
                _unscreenedTrunkGroupOriginationAttestationLevel = value;
            }
        }

        [XmlIgnore]
        protected bool UnscreenedTrunkGroupOriginationAttestationLevelSpecified { get; set; }

    }
}
