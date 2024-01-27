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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b5e86c5d60603bdb61de308d278500d9:115""}]")]
    public class GroupCallCenterMonitoringGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _enableSupervisorCoaching;

        [XmlElement(ElementName = "enableSupervisorCoaching", IsNullable = false, Namespace = "")]
        [Group(@"b5e86c5d60603bdb61de308d278500d9:115")]
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
