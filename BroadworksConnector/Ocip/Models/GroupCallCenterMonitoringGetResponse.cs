using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupCallCenterMonitoringGetRequest.
    /// <see cref="GroupCallCenterMonitoringGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""41b968f87257b8dd553215179161ccb4:116""}]")]
    public class GroupCallCenterMonitoringGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _enableSupervisorCoaching;

        [XmlElement(ElementName = "enableSupervisorCoaching", IsNullable = false, Namespace = "")]
        [Group(@"41b968f87257b8dd553215179161ccb4:116")]
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

    }
}
