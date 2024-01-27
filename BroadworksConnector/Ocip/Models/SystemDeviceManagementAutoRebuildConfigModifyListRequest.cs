using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to enable or disable automatic trigger of DM events for
    /// OCI request prefixes, regardless of the request's
    /// version.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:7802""}]")]
    public class SystemDeviceManagementAutoRebuildConfigModifyListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected List<BroadWorksConnector.Ocip.Models.DeviceManagementAutoRebuildConfigEntry> _autoRebuildConfigEntry = new List<BroadWorksConnector.Ocip.Models.DeviceManagementAutoRebuildConfigEntry>();

        [XmlElement(ElementName = "autoRebuildConfigEntry", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:7802")]
        public List<BroadWorksConnector.Ocip.Models.DeviceManagementAutoRebuildConfigEntry> AutoRebuildConfigEntry
        {
            get => _autoRebuildConfigEntry;
            set
            {
                AutoRebuildConfigEntrySpecified = true;
                _autoRebuildConfigEntry = value;
            }
        }

        [XmlIgnore]
        protected bool AutoRebuildConfigEntrySpecified { get; set; }

    }
}
