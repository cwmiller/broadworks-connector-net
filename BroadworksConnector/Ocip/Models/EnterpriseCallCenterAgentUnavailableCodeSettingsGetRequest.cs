using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the enterprise level data associated with Call Center Agents Unavailable Code Settings.
    /// The response is either an EnterpriseCallCenterAgentUnavailableCodeSettingsGetResponse or an
    /// ErrorResponse.
    /// 
    /// Replaced by EnterpriseCallCenterAgentUnavailableCodeSettingsGetRequest17sp4.
    /// <see cref="EnterpriseCallCenterAgentUnavailableCodeSettingsGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="EnterpriseCallCenterAgentUnavailableCodeSettingsGetRequest17sp4"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:2068""}]")]
    public class EnterpriseCallCenterAgentUnavailableCodeSettingsGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:2068")]
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

    }
}
