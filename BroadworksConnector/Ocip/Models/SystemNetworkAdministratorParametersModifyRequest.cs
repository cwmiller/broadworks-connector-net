using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the network administrator settings for the system.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:12488""}]")]
    public class SystemNetworkAdministratorParametersModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected bool _enabled;

        [XmlElement(ElementName = "enabled", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:12488")]
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
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:12488")]
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
