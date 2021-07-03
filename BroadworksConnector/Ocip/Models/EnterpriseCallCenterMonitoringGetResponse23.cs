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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""41b968f87257b8dd553215179161ccb4:64""}]")]
    public class EnterpriseCallCenterMonitoringGetResponse23 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _enableSupervisorCoaching;

        [XmlElement(ElementName = "enableSupervisorCoaching", IsNullable = false, Namespace = "")]
        [Group(@"41b968f87257b8dd553215179161ccb4:64")]
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

        private bool _bypassEnforcementOfSupervisorAgentRelationship;

        [XmlElement(ElementName = "bypassEnforcementOfSupervisorAgentRelationship", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"41b968f87257b8dd553215179161ccb4:64")]
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
