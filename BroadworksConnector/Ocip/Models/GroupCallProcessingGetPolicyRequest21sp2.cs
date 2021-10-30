using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the group level data associated with Call Processing Policy.
    /// The response is either a GroupCallProcessingGetPolicyResponse21sp2 or an ErrorResponse.
    /// The useGroupCLIDSetting attribute controls the CLID settings
    /// (clidPolicy,enterpriseCallsCLIDPolicy, groupCallsCLIDPolicy, emergencyClidPolicy, allowAlternateNumbersForRedirectingIdentity, useGroupName, allowDepartmentCLIDNameOverride)
    /// The useGroupMediaSetting attribute controls the Media settings
    /// (medisPolicySelection, supportedMediaSetName)
    /// The useGroupCallLimitsSetting attribute controls the Call Limits settings
    /// (useMaxSimultaneousCalls, maxSimultaneousCalls,
    /// useMaxSimultaneousVideoCalls, maxSimultaneousVideoCalls, useMaxCallTimeForAnsweredCalls, maxCallTimeForAnsweredCallsMinutes, useMaxCallTimeForUnansweredCalls, maxCallTimeForUnansweredCallsMinutes, useMaxConcurrentRedirectedCalls, useMaxFindMeFollowMeDepth, maxRedirectionDepth, useMaxConcurrentFindMeFollowMeInvocations, maxConcurrentFindMeFollowMeInvocations)
    /// The useGroupTranslationRoutingSetting attribute controls the routing and translation settings
    /// (networkUsageSelection, enforceGroupCallingLineIdentityRestriction,
    /// allowEnterpriseGroupCallTypingForPrivateDialingPlan, allowEnterpriseGroupCallTypingForPublicDialingPlan, overrideCLIDRestrictionForExternalCallsViaPrivateDialingPlan, enableEnterpriseExtensionDialing, routeOverrideDomain, routeOverridePrefix)
    /// 
    /// Replaced by: GroupCallProcessingGetPolicyRequest22 in AS data mode
    /// <see cref="GroupCallProcessingGetPolicyResponse21sp2"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="GroupCallProcessingGetPolicyRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:1784""}]")]
    public class GroupCallProcessingGetPolicyRequest21sp2 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.GroupCallProcessingGetPolicyResponse21sp2>
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:1784")]
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

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:1784")]
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

    }
}
