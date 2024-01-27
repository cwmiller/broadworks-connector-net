using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemNetworkAdministratorParametersGetRequest.
    /// The response contains the network administrator settings for the system.
    /// <see cref="SystemNetworkAdministratorParametersGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:12471""}]")]
    public class SystemNetworkAdministratorParametersGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _enabled;

        [XmlElement(ElementName = "enabled", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:12471")]
        public bool Enabled
        {
            get => _enabled;
            set
            {
                EnabledSpecified = true;
                _enabled = value;
            }
        }

        [XmlIgnore]
        protected bool EnabledSpecified { get; set; }

        protected int _cacheRefreshIntervalInMinutes;

        [XmlElement(ElementName = "cacheRefreshIntervalInMinutes", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:12471")]
        [MinInclusive(1)]
        [MaxInclusive(1440)]
        public int CacheRefreshIntervalInMinutes
        {
            get => _cacheRefreshIntervalInMinutes;
            set
            {
                CacheRefreshIntervalInMinutesSpecified = true;
                _cacheRefreshIntervalInMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool CacheRefreshIntervalInMinutesSpecified { get; set; }

    }
}
