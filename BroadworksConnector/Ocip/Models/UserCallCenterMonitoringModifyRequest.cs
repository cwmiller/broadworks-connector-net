using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the user's Call Center Monitoring settings.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""41b968f87257b8dd553215179161ccb4:182""}]")]
    public class UserCallCenterMonitoringModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"41b968f87257b8dd553215179161ccb4:182")]
        [MinLength(1)]
        [MaxLength(161)]
        public string UserId
        {
            get => _userId;
            set
            {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        protected bool UserIdSpecified { get; set; }

        private bool _playToneToAgentForSilentMonitoring;

        [XmlElement(ElementName = "playToneToAgentForSilentMonitoring", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"41b968f87257b8dd553215179161ccb4:182")]
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
        [Optional]
        [Group(@"41b968f87257b8dd553215179161ccb4:182")]
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
