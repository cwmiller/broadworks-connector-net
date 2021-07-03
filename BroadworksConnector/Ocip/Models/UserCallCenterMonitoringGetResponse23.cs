using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserCallCenterMonitoringGetRequest23.
    /// <see cref="UserCallCenterMonitoringGetRequest23"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""41b968f87257b8dd553215179161ccb4:165""}]")]
    public class UserCallCenterMonitoringGetResponse23 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _playToneToAgentForSilentMonitoring;

        [XmlElement(ElementName = "playToneToAgentForSilentMonitoring", IsNullable = false, Namespace = "")]
        [Group(@"41b968f87257b8dd553215179161ccb4:165")]
        public bool PlayToneToAgentForSilentMonitoring
        {
            get => _playToneToAgentForSilentMonitoring;
            set
            {
                PlayToneToAgentForSilentMonitoringSpecified = true;
                _playToneToAgentForSilentMonitoring = value;
            }
        }

        [XmlIgnore]
        protected bool PlayToneToAgentForSilentMonitoringSpecified { get; set; }

        private bool _playToneToAgentForSupervisorCoaching;

        [XmlElement(ElementName = "playToneToAgentForSupervisorCoaching", IsNullable = false, Namespace = "")]
        [Group(@"41b968f87257b8dd553215179161ccb4:165")]
        public bool PlayToneToAgentForSupervisorCoaching
        {
            get => _playToneToAgentForSupervisorCoaching;
            set
            {
                PlayToneToAgentForSupervisorCoachingSpecified = true;
                _playToneToAgentForSupervisorCoaching = value;
            }
        }

        [XmlIgnore]
        protected bool PlayToneToAgentForSupervisorCoachingSpecified { get; set; }

    }
}
