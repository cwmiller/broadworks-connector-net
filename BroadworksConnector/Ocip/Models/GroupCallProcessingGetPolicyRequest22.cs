using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the group level data associated with Call Processing Policy.
    /// The response is either a GroupCallProcessingGetPolicyResponse22 or an
    /// ErrorResponse.
    /// The useGroupCLIDSetting attribute controls the CLID settings
    /// (clidPolicy,enterpriseCallsCLIDPolicy, groupCallsCLIDPolicy, emergencyClidPolicy, allowAlternateNumbersForRedirectingIdentity, useGroupName, allowDepartmentCLIDNameOverride)
    /// The useGroupMediaSetting attribute controls the Media settings
    /// (medisPolicySelection, supportedMediaSetName)
    /// The useGroupCallLimitsSetting attribute controls the Call Limits settings
    /// (useMaxSimultaneousCalls, maxSimultaneousCalls,
    /// useMaxSimultaneousVideoCalls, maxSimultaneousVideoCalls, useMaxCallTimeForAnsweredCalls,
    /// maxCallTimeForAnsweredCallsMinutes, useMaxCallTimeForUnansweredCalls, maxCallTimeForUnansweredCallsMinutes,
    /// useMaxConcurrentRedirectedCalls, useMaxFindMeFollowMeDepth, maxRedirectionDepth,
    /// useMaxConcurrentFindMeFollowMeInvocations, maxConcurrentFindMeFollowMeInvocations,
    /// useMaxConcurrentTerminatingAlertingRequests, maxConcurrentTerminatingAlertingRequests)
    /// The useGroupTranslationRoutingSetting attribute controls the routing and translation settings
    /// (networkUsageSelection, enforceGroupCallingLineIdentityRestriction,
    /// allowEnterpriseGroupCallTypingForPrivateDialingPlan, allowEnterpriseGroupCallTypingForPublicDialingPlan, overrideCLIDRestrictionForExternalCallsViaPrivateDialingPlan, enableEnterpriseExtensionDialing)
    /// Replaced by: GroupCallProcessingGetPolicyRequest22V2 in AS data mode.
    /// <see cref="GroupCallProcessingGetPolicyResponse22"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="useMaxConcurrentTerminatingAlertingRequests"/>
    /// <see cref="maxConcurrentTerminatingAlertingRequests"/>
    /// <see cref="GroupCallProcessingGetPolicyRequest22V2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:4343""}]")]
    public class GroupCallProcessingGetPolicyRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:4343")]
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
        public bool ServiceProviderIdSpecified { get; set; }

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:4343")]
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
        public bool GroupIdSpecified { get; set; }

    }
}
