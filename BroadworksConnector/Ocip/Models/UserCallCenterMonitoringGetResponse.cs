using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserCallCenterMonitoringGetRequest.
    /// <see cref="UserCallCenterMonitoringGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""41b968f87257b8dd553215179161ccb4:58""}]")]
    public class UserCallCenterMonitoringGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _playToneToAgentForSilentMonitoring;

        [XmlElement(ElementName = "playToneToAgentForSilentMonitoring", IsNullable = false, Namespace = "")]
        [Group(@"41b968f87257b8dd553215179161ccb4:58")]
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

    }
}
