using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to EnterpriseCallCenterMonitoringGetRequest23.
    /// <see cref="EnterpriseCallCenterMonitoringGetRequest23"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b5e86c5d60603bdb61de308d278500d9:63""}]")]
    public class EnterpriseCallCenterMonitoringGetResponse23 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _enableSupervisorCoaching;

        [XmlElement(ElementName = "enableSupervisorCoaching", IsNullable = false, Namespace = "")]
        [Group(@"b5e86c5d60603bdb61de308d278500d9:63")]
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
        [Group(@"b5e86c5d60603bdb61de308d278500d9:63")]
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
