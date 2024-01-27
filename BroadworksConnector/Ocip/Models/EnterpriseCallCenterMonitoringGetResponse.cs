using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to EnterpriseCallCenterMonitoringGetRequest.
    /// <see cref="EnterpriseCallCenterMonitoringGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:2309""}]")]
    public class EnterpriseCallCenterMonitoringGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _enableSupervisorCoaching;

        [XmlElement(ElementName = "enableSupervisorCoaching", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:2309")]
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
