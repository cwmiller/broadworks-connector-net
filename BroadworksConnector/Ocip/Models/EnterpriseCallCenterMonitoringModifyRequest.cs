using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the enterprise level data associated with Call Center Monitoring
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b5e86c5d60603bdb61de308d278500d9:80""}]")]
    public class EnterpriseCallCenterMonitoringModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"b5e86c5d60603bdb61de308d278500d9:80")]
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

        protected bool _enableSupervisorCoaching;

        [XmlElement(ElementName = "enableSupervisorCoaching", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b5e86c5d60603bdb61de308d278500d9:80")]
        public bool EnableSupervisorCoaching
        {
            get => _enableSupervisorCoaching;
            set
            {
                EnableSupervisorCoachingSpecified = true;
                _enableSupervisorCoaching = value;
            }
        }

        [XmlIgnore]
        protected bool EnableSupervisorCoachingSpecified { get; set; }

        protected bool _bypassEnforcementOfSupervisorAgentRelationship;

        [XmlElement(ElementName = "bypassEnforcementOfSupervisorAgentRelationship", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b5e86c5d60603bdb61de308d278500d9:80")]
        public bool BypassEnforcementOfSupervisorAgentRelationship
        {
            get => _bypassEnforcementOfSupervisorAgentRelationship;
            set
            {
                BypassEnforcementOfSupervisorAgentRelationshipSpecified = true;
                _bypassEnforcementOfSupervisorAgentRelationship = value;
            }
        }

        [XmlIgnore]
        protected bool BypassEnforcementOfSupervisorAgentRelationshipSpecified { get; set; }

    }
}
