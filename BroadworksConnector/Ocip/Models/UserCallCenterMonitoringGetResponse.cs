using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserCallCenterMonitoringGetRequest.
    /// Replaced by UserCallCenterMonitoringGetResponse23
    /// <see cref="UserCallCenterMonitoringGetRequest"/>
    /// <see cref="UserCallCenterMonitoringGetResponse23"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:41355""}]")]
    public class UserCallCenterMonitoringGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _playToneToAgentForSilentMonitoring;

        [XmlElement(ElementName = "playToneToAgentForSilentMonitoring", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:41355")]
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
