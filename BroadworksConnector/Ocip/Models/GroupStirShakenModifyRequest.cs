using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify Group Stir Shaken service settings.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:8196""}]")]
    public class GroupStirShakenModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:8196")]
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

        protected string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:8196")]
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
        protected bool GroupIdSpecified { get; set; }

        protected bool? _useParentLevelSettings;

        [XmlElement(ElementName = "useParentLevelSettings", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:8196")]
        public bool? UseParentLevelSettings
        {
            get => _useParentLevelSettings;
            set
            {
                UseParentLevelSettingsSpecified = (value != null);
                _useParentLevelSettings = value;
            }
        }

        [XmlIgnore]
        protected bool UseParentLevelSettingsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.StirShakenSigningPolicy? _signingPolicy;

        [XmlElement(ElementName = "signingPolicy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:8196")]
        public BroadWorksConnector.Ocip.Models.StirShakenSigningPolicy? SigningPolicy
        {
            get => _signingPolicy;
            set
            {
                SigningPolicySpecified = (value != null);
                _signingPolicy = value;
            }
        }

        [XmlIgnore]
        protected bool SigningPolicySpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.StirShakenTaggingPolicy? _taggingPolicy;

        [XmlElement(ElementName = "taggingPolicy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:8196")]
        public BroadWorksConnector.Ocip.Models.StirShakenTaggingPolicy? TaggingPolicy
        {
            get => _taggingPolicy;
            set
            {
                TaggingPolicySpecified = (value != null);
                _taggingPolicy = value;
            }
        }

        [XmlIgnore]
        protected bool TaggingPolicySpecified { get; set; }

        protected string _signingServiceURL;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "signingServiceURL", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:8196")]
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

        protected BroadWorksConnector.Ocip.Models.StirShakenTagFromOrPAI? _tagFromOrPAI;

        [XmlElement(ElementName = "tagFromOrPAI", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:8196")]
        public BroadWorksConnector.Ocip.Models.StirShakenTagFromOrPAI? TagFromOrPAI
        {
            get => _tagFromOrPAI;
            set
            {
                TagFromOrPAISpecified = (value != null);
                _tagFromOrPAI = value;
            }
        }

        [XmlIgnore]
        protected bool TagFromOrPAISpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.StirShakenVerstatTag? _verstatTag;

        [XmlElement(ElementName = "verstatTag", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:8196")]
        public BroadWorksConnector.Ocip.Models.StirShakenVerstatTag? VerstatTag
        {
            get => _verstatTag;
            set
            {
                VerstatTagSpecified = (value != null);
                _verstatTag = value;
            }
        }

        [XmlIgnore]
        protected bool VerstatTagSpecified { get; set; }

        protected bool? _useOSValueForOrigId;

        [XmlElement(ElementName = "useOSValueForOrigId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:8196")]
        public bool? UseOSValueForOrigId
        {
            get => _useOSValueForOrigId;
            set
            {
                UseOSValueForOrigIdSpecified = (value != null);
                _useOSValueForOrigId = value;
            }
        }

        [XmlIgnore]
        protected bool UseOSValueForOrigIdSpecified { get; set; }

        protected string _origUUID;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "origUUID", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:8196")]
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

        protected BroadWorksConnector.Ocip.Models.StirShakenAttestationLevel? _attestationLevel;

        [XmlElement(ElementName = "attestationLevel", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:8196")]
        public BroadWorksConnector.Ocip.Models.StirShakenAttestationLevel? AttestationLevel
        {
            get => _attestationLevel;
            set
            {
                AttestationLevelSpecified = (value != null);
                _attestationLevel = value;
            }
        }

        [XmlIgnore]
        protected bool AttestationLevelSpecified { get; set; }

        protected bool? _enableVerification;

        [XmlElement(ElementName = "enableVerification", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:8196")]
        public bool? EnableVerification
        {
            get => _enableVerification;
            set
            {
                EnableVerificationSpecified = (value != null);
                _enableVerification = value;
            }
        }

        [XmlIgnore]
        protected bool EnableVerificationSpecified { get; set; }

        protected string _verificationServiceURL;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "verificationServiceURL", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:8196")]
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

        protected BroadWorksConnector.Ocip.Models.StirShakenVerificationErrorHandling? _verificationErrorHandling;

        [XmlElement(ElementName = "verificationErrorHandling", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:8196")]
        public BroadWorksConnector.Ocip.Models.StirShakenVerificationErrorHandling? VerificationErrorHandling
        {
            get => _verificationErrorHandling;
            set
            {
                VerificationErrorHandlingSpecified = (value != null);
                _verificationErrorHandling = value;
            }
        }

        [XmlIgnore]
        protected bool VerificationErrorHandlingSpecified { get; set; }

        protected bool? _proxyVerstatToCNAMSubscribe;

        [XmlElement(ElementName = "proxyVerstatToCNAMSubscribe", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:8196")]
        public bool? ProxyVerstatToCNAMSubscribe
        {
            get => _proxyVerstatToCNAMSubscribe;
            set
            {
                ProxyVerstatToCNAMSubscribeSpecified = (value != null);
                _proxyVerstatToCNAMSubscribe = value;
            }
        }

        [XmlIgnore]
        protected bool ProxyVerstatToCNAMSubscribeSpecified { get; set; }

        protected bool? _useUnknownHeadersFromCNAMNotify;

        [XmlElement(ElementName = "useUnknownHeadersFromCNAMNotify", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:8196")]
        public bool? UseUnknownHeadersFromCNAMNotify
        {
            get => _useUnknownHeadersFromCNAMNotify;
            set
            {
                UseUnknownHeadersFromCNAMNotifySpecified = (value != null);
                _useUnknownHeadersFromCNAMNotify = value;
            }
        }

        [XmlIgnore]
        protected bool UseUnknownHeadersFromCNAMNotifySpecified { get; set; }

        protected bool? _enableSigningForUnscreenedTrunkGroupOriginations;

        [XmlElement(ElementName = "enableSigningForUnscreenedTrunkGroupOriginations", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:8196")]
        public bool? EnableSigningForUnscreenedTrunkGroupOriginations
        {
            get => _enableSigningForUnscreenedTrunkGroupOriginations;
            set
            {
                EnableSigningForUnscreenedTrunkGroupOriginationsSpecified = (value != null);
                _enableSigningForUnscreenedTrunkGroupOriginations = value;
            }
        }

        [XmlIgnore]
        protected bool EnableSigningForUnscreenedTrunkGroupOriginationsSpecified { get; set; }

        protected bool? _enableTaggingForUnscreenedTrunkGroupOriginations;

        [XmlElement(ElementName = "enableTaggingForUnscreenedTrunkGroupOriginations", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:8196")]
        public bool? EnableTaggingForUnscreenedTrunkGroupOriginations
        {
            get => _enableTaggingForUnscreenedTrunkGroupOriginations;
            set
            {
                EnableTaggingForUnscreenedTrunkGroupOriginationsSpecified = (value != null);
                _enableTaggingForUnscreenedTrunkGroupOriginations = value;
            }
        }

        [XmlIgnore]
        protected bool EnableTaggingForUnscreenedTrunkGroupOriginationsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.StirShakenUnscreenedTrunkGroupOriginationAttestationLevel? _unscreenedTrunkGroupOriginationAttestationLevel;

        [XmlElement(ElementName = "unscreenedTrunkGroupOriginationAttestationLevel", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:8196")]
        public BroadWorksConnector.Ocip.Models.StirShakenUnscreenedTrunkGroupOriginationAttestationLevel? UnscreenedTrunkGroupOriginationAttestationLevel
        {
            get => _unscreenedTrunkGroupOriginationAttestationLevel;
            set
            {
                UnscreenedTrunkGroupOriginationAttestationLevelSpecified = (value != null);
                _unscreenedTrunkGroupOriginationAttestationLevel = value;
            }
        }

        [XmlIgnore]
        protected bool UnscreenedTrunkGroupOriginationAttestationLevelSpecified { get; set; }

        protected bool? _includeTaggedHeadersToAccessSide;

        [XmlElement(ElementName = "includeTaggedHeadersToAccessSide", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:8196")]
        public bool? IncludeTaggedHeadersToAccessSide
        {
            get => _includeTaggedHeadersToAccessSide;
            set
            {
                IncludeTaggedHeadersToAccessSideSpecified = (value != null);
                _includeTaggedHeadersToAccessSide = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeTaggedHeadersToAccessSideSpecified { get; set; }

        protected bool? _proxyIdentityHeaderToAccessSide;

        [XmlElement(ElementName = "proxyIdentityHeaderToAccessSide", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:8196")]
        public bool? ProxyIdentityHeaderToAccessSide
        {
            get => _proxyIdentityHeaderToAccessSide;
            set
            {
                ProxyIdentityHeaderToAccessSideSpecified = (value != null);
                _proxyIdentityHeaderToAccessSide = value;
            }
        }

        [XmlIgnore]
        protected bool ProxyIdentityHeaderToAccessSideSpecified { get; set; }

        protected bool? _checkDirectoryNumbersForAttestation;

        [XmlElement(ElementName = "checkDirectoryNumbersForAttestation", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:8196")]
        public bool? CheckDirectoryNumbersForAttestation
        {
            get => _checkDirectoryNumbersForAttestation;
            set
            {
                CheckDirectoryNumbersForAttestationSpecified = (value != null);
                _checkDirectoryNumbersForAttestation = value;
            }
        }

        [XmlIgnore]
        protected bool CheckDirectoryNumbersForAttestationSpecified { get; set; }

        protected bool? _matchUnassignedNumbersOnly;

        [XmlElement(ElementName = "matchUnassignedNumbersOnly", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:8196")]
        public bool? MatchUnassignedNumbersOnly
        {
            get => _matchUnassignedNumbersOnly;
            set
            {
                MatchUnassignedNumbersOnlySpecified = (value != null);
                _matchUnassignedNumbersOnly = value;
            }
        }

        [XmlIgnore]
        protected bool MatchUnassignedNumbersOnlySpecified { get; set; }

        protected bool? _enableTaggingForRedirectedCalls;

        [XmlElement(ElementName = "enableTaggingForRedirectedCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:8196")]
        public bool? EnableTaggingForRedirectedCalls
        {
            get => _enableTaggingForRedirectedCalls;
            set
            {
                EnableTaggingForRedirectedCallsSpecified = (value != null);
                _enableTaggingForRedirectedCalls = value;
            }
        }

        [XmlIgnore]
        protected bool EnableTaggingForRedirectedCallsSpecified { get; set; }

        protected bool? _preferIngressTagging;

        [XmlElement(ElementName = "preferIngressTagging", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:8196")]
        public bool? PreferIngressTagging
        {
            get => _preferIngressTagging;
            set
            {
                PreferIngressTaggingSpecified = (value != null);
                _preferIngressTagging = value;
            }
        }

        [XmlIgnore]
        protected bool PreferIngressTaggingSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.StirShakenSigningPolicy? _accessSideIngressIdentityHeaderProxyPolicy;

        [XmlElement(ElementName = "accessSideIngressIdentityHeaderProxyPolicy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:8196")]
        public BroadWorksConnector.Ocip.Models.StirShakenSigningPolicy? AccessSideIngressIdentityHeaderProxyPolicy
        {
            get => _accessSideIngressIdentityHeaderProxyPolicy;
            set
            {
                AccessSideIngressIdentityHeaderProxyPolicySpecified = (value != null);
                _accessSideIngressIdentityHeaderProxyPolicy = value;
            }
        }

        [XmlIgnore]
        protected bool AccessSideIngressIdentityHeaderProxyPolicySpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.StirShakenTaggingPolicy? _accessSideIngressTaggingProxyPolicy;

        [XmlElement(ElementName = "accessSideIngressTaggingProxyPolicy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:8196")]
        public BroadWorksConnector.Ocip.Models.StirShakenTaggingPolicy? AccessSideIngressTaggingProxyPolicy
        {
            get => _accessSideIngressTaggingProxyPolicy;
            set
            {
                AccessSideIngressTaggingProxyPolicySpecified = (value != null);
                _accessSideIngressTaggingProxyPolicy = value;
            }
        }

        [XmlIgnore]
        protected bool AccessSideIngressTaggingProxyPolicySpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.StirShakenIdentityHeadersHandling? _identityHeadersHandlingForRedirectedCalls;

        [XmlElement(ElementName = "identityHeadersHandlingForRedirectedCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:8196")]
        public BroadWorksConnector.Ocip.Models.StirShakenIdentityHeadersHandling? IdentityHeadersHandlingForRedirectedCalls
        {
            get => _identityHeadersHandlingForRedirectedCalls;
            set
            {
                IdentityHeadersHandlingForRedirectedCallsSpecified = (value != null);
                _identityHeadersHandlingForRedirectedCalls = value;
            }
        }

        [XmlIgnore]
        protected bool IdentityHeadersHandlingForRedirectedCallsSpecified { get; set; }

        protected bool? _enableVerificationForRedirectedCalls;

        [XmlElement(ElementName = "enableVerificationForRedirectedCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:8196")]
        public bool? EnableVerificationForRedirectedCalls
        {
            get => _enableVerificationForRedirectedCalls;
            set
            {
                EnableVerificationForRedirectedCallsSpecified = (value != null);
                _enableVerificationForRedirectedCalls = value;
            }
        }

        [XmlIgnore]
        protected bool EnableVerificationForRedirectedCallsSpecified { get; set; }

    }
}
