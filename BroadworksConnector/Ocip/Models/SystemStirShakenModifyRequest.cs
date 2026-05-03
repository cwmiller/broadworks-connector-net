using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify system Stir Shaken service settings.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:18450""}]")]
    public class SystemStirShakenModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected BroadWorksConnector.Ocip.Models.StirShakenSigningPolicy? _signingPolicy;

        [XmlElement(ElementName = "signingPolicy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:18450")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:18450")]
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

        protected bool? _signEmergencyCalls;

        [XmlElement(ElementName = "signEmergencyCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:18450")]
        public bool? SignEmergencyCalls
        {
            get => _signEmergencyCalls;
            set
            {
                SignEmergencyCallsSpecified = (value != null);
                _signEmergencyCalls = value;
            }
        }

        [XmlIgnore]
        protected bool SignEmergencyCallsSpecified { get; set; }

        protected bool? _tagEmergencyCalls;

        [XmlElement(ElementName = "tagEmergencyCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:18450")]
        public bool? TagEmergencyCalls
        {
            get => _tagEmergencyCalls;
            set
            {
                TagEmergencyCallsSpecified = (value != null);
                _tagEmergencyCalls = value;
            }
        }

        [XmlIgnore]
        protected bool TagEmergencyCallsSpecified { get; set; }

        protected string _signingServiceURL;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "signingServiceURL", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:18450")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:18450")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:18450")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:18450")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:18450")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:18450")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:18450")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:18450")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:18450")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:18450")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:18450")]
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

        protected bool? _useTS24229Headers;

        [XmlElement(ElementName = "useTS24229Headers", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:18450")]
        public bool? UseTS24229Headers
        {
            get => _useTS24229Headers;
            set
            {
                UseTS24229HeadersSpecified = (value != null);
                _useTS24229Headers = value;
            }
        }

        [XmlIgnore]
        protected bool UseTS24229HeadersSpecified { get; set; }

        protected bool? _enableSigningForUnscreenedTrunkGroupOriginations;

        [XmlElement(ElementName = "enableSigningForUnscreenedTrunkGroupOriginations", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:18450")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:18450")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:18450")]
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

        protected bool? _verifyGETSCalls;

        [XmlElement(ElementName = "verifyGETSCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:18450")]
        public bool? VerifyGETSCalls
        {
            get => _verifyGETSCalls;
            set
            {
                VerifyGETSCallsSpecified = (value != null);
                _verifyGETSCalls = value;
            }
        }

        [XmlIgnore]
        protected bool VerifyGETSCallsSpecified { get; set; }

        protected bool? _allowPartialIngressTagging;

        [XmlElement(ElementName = "allowPartialIngressTagging", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:18450")]
        public bool? AllowPartialIngressTagging
        {
            get => _allowPartialIngressTagging;
            set
            {
                AllowPartialIngressTaggingSpecified = (value != null);
                _allowPartialIngressTagging = value;
            }
        }

        [XmlIgnore]
        protected bool AllowPartialIngressTaggingSpecified { get; set; }

        protected bool? _includeVerstatToMobileNetworkLocations;

        [XmlElement(ElementName = "includeVerstatToMobileNetworkLocations", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:18450")]
        public bool? IncludeVerstatToMobileNetworkLocations
        {
            get => _includeVerstatToMobileNetworkLocations;
            set
            {
                IncludeVerstatToMobileNetworkLocationsSpecified = (value != null);
                _includeVerstatToMobileNetworkLocations = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeVerstatToMobileNetworkLocationsSpecified { get; set; }

        protected bool? _allowVerstatInSIPURIWithPhoneCorrection;

        [XmlElement(ElementName = "allowVerstatInSIPURIWithPhoneCorrection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:18450")]
        public bool? AllowVerstatInSIPURIWithPhoneCorrection
        {
            get => _allowVerstatInSIPURIWithPhoneCorrection;
            set
            {
                AllowVerstatInSIPURIWithPhoneCorrectionSpecified = (value != null);
                _allowVerstatInSIPURIWithPhoneCorrection = value;
            }
        }

        [XmlIgnore]
        protected bool AllowVerstatInSIPURIWithPhoneCorrectionSpecified { get; set; }

        protected bool? _includeTaggedHeadersToAccessSide;

        [XmlElement(ElementName = "includeTaggedHeadersToAccessSide", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:18450")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:18450")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:18450")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:18450")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:18450")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:18450")]
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

        protected bool? _preferFromForAttestation;

        [XmlElement(ElementName = "preferFromForAttestation", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:18450")]
        public bool? PreferFromForAttestation
        {
            get => _preferFromForAttestation;
            set
            {
                PreferFromForAttestationSpecified = (value != null);
                _preferFromForAttestation = value;
            }
        }

        [XmlIgnore]
        protected bool PreferFromForAttestationSpecified { get; set; }

        protected bool? _preferFromForIdentityVerification;

        [XmlElement(ElementName = "preferFromForIdentityVerification", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:18450")]
        public bool? PreferFromForIdentityVerification
        {
            get => _preferFromForIdentityVerification;
            set
            {
                PreferFromForIdentityVerificationSpecified = (value != null);
                _preferFromForIdentityVerification = value;
            }
        }

        [XmlIgnore]
        protected bool PreferFromForIdentityVerificationSpecified { get; set; }

        protected bool? _includeVerstatInDiversionOrHistoryInfo;

        [XmlElement(ElementName = "includeVerstatInDiversionOrHistoryInfo", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:18450")]
        public bool? IncludeVerstatInDiversionOrHistoryInfo
        {
            get => _includeVerstatInDiversionOrHistoryInfo;
            set
            {
                IncludeVerstatInDiversionOrHistoryInfoSpecified = (value != null);
                _includeVerstatInDiversionOrHistoryInfo = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeVerstatInDiversionOrHistoryInfoSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.StirShakenSigningPolicy? _accessSideIngressIdentityHeaderProxyPolicy;

        [XmlElement(ElementName = "accessSideIngressIdentityHeaderProxyPolicy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:18450")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:18450")]
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

        protected bool? _includeVerstatToInterNetworkCalls;

        [XmlElement(ElementName = "includeVerstatToInterNetworkCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:18450")]
        public bool? IncludeVerstatToInterNetworkCalls
        {
            get => _includeVerstatToInterNetworkCalls;
            set
            {
                IncludeVerstatToInterNetworkCallsSpecified = (value != null);
                _includeVerstatToInterNetworkCalls = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeVerstatToInterNetworkCallsSpecified { get; set; }

        protected bool? _includeVerstatToIntraNetworkCalls;

        [XmlElement(ElementName = "includeVerstatToIntraNetworkCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:18450")]
        public bool? IncludeVerstatToIntraNetworkCalls
        {
            get => _includeVerstatToIntraNetworkCalls;
            set
            {
                IncludeVerstatToIntraNetworkCallsSpecified = (value != null);
                _includeVerstatToIntraNetworkCalls = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeVerstatToIntraNetworkCallsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.StirShakenApiCompatibility? _apiCompatibility;

        [XmlElement(ElementName = "apiCompatibility", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:18450")]
        public BroadWorksConnector.Ocip.Models.StirShakenApiCompatibility? ApiCompatibility
        {
            get => _apiCompatibility;
            set
            {
                ApiCompatibilitySpecified = (value != null);
                _apiCompatibility = value;
            }
        }

        [XmlIgnore]
        protected bool ApiCompatibilitySpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.StirShakenIdentityHeadersHandling? _identityHeadersHandlingForRedirectedCalls;

        [XmlElement(ElementName = "identityHeadersHandlingForRedirectedCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:18450")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:18450")]
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
