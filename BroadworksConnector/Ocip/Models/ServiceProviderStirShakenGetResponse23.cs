using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the ServiceProviderStirShakenGetRequest23.
    /// <see cref="ServiceProviderStirShakenGetRequest23"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:6927""}]")]
    public class ServiceProviderStirShakenGetResponse23 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _useParentLevelSettings;

        [XmlElement(ElementName = "useParentLevelSettings", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:6927")]
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
        [Group(@"e19a9072c2dad499e9f28837da5768db:6927")]
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
        [Group(@"e19a9072c2dad499e9f28837da5768db:6927")]
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
        [Group(@"e19a9072c2dad499e9f28837da5768db:6927")]
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
        [Group(@"e19a9072c2dad499e9f28837da5768db:6927")]
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
        [Group(@"e19a9072c2dad499e9f28837da5768db:6927")]
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
        [Group(@"e19a9072c2dad499e9f28837da5768db:6927")]
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
        [Group(@"e19a9072c2dad499e9f28837da5768db:6927")]
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
        [Group(@"e19a9072c2dad499e9f28837da5768db:6927")]
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
        [Group(@"e19a9072c2dad499e9f28837da5768db:6927")]
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
        [Group(@"e19a9072c2dad499e9f28837da5768db:6927")]
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
        [Group(@"e19a9072c2dad499e9f28837da5768db:6927")]
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
        [Group(@"e19a9072c2dad499e9f28837da5768db:6927")]
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
        [Group(@"e19a9072c2dad499e9f28837da5768db:6927")]
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
        [Group(@"e19a9072c2dad499e9f28837da5768db:6927")]
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
        [Group(@"e19a9072c2dad499e9f28837da5768db:6927")]
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
        [Group(@"e19a9072c2dad499e9f28837da5768db:6927")]
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

        protected bool _includeTaggedHeadersToAccessSide;

        [XmlElement(ElementName = "includeTaggedHeadersToAccessSide", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:6927")]
        public bool IncludeTaggedHeadersToAccessSide
        {
            get => _includeTaggedHeadersToAccessSide;
            set
            {
                IncludeTaggedHeadersToAccessSideSpecified = true;
                _includeTaggedHeadersToAccessSide = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeTaggedHeadersToAccessSideSpecified { get; set; }

        protected bool _proxyIdentityHeaderToAccessSide;

        [XmlElement(ElementName = "proxyIdentityHeaderToAccessSide", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:6927")]
        public bool ProxyIdentityHeaderToAccessSide
        {
            get => _proxyIdentityHeaderToAccessSide;
            set
            {
                ProxyIdentityHeaderToAccessSideSpecified = true;
                _proxyIdentityHeaderToAccessSide = value;
            }
        }

        [XmlIgnore]
        protected bool ProxyIdentityHeaderToAccessSideSpecified { get; set; }

        protected bool _checkDirectoryNumbersForAttestation;

        [XmlElement(ElementName = "checkDirectoryNumbersForAttestation", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:6927")]
        public bool CheckDirectoryNumbersForAttestation
        {
            get => _checkDirectoryNumbersForAttestation;
            set
            {
                CheckDirectoryNumbersForAttestationSpecified = true;
                _checkDirectoryNumbersForAttestation = value;
            }
        }

        [XmlIgnore]
        protected bool CheckDirectoryNumbersForAttestationSpecified { get; set; }

        protected bool _matchUnassignedNumbersOnly;

        [XmlElement(ElementName = "matchUnassignedNumbersOnly", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:6927")]
        public bool MatchUnassignedNumbersOnly
        {
            get => _matchUnassignedNumbersOnly;
            set
            {
                MatchUnassignedNumbersOnlySpecified = true;
                _matchUnassignedNumbersOnly = value;
            }
        }

        [XmlIgnore]
        protected bool MatchUnassignedNumbersOnlySpecified { get; set; }

    }
}
