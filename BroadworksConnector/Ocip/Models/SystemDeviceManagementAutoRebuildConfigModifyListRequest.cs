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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:6992""}]")]
    public class SystemDeviceManagementAutoRebuildConfigModifyListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private List<BroadWorksConnector.Ocip.Models.DeviceManagementAutoRebuildConfigEntry> _autoRebuildConfigEntry = new List<BroadWorksConnector.Ocip.Models.DeviceManagementAutoRebuildConfigEntry>();

        [XmlElement(ElementName = "autoRebuildConfigEntry", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:6992")]
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
        public bool AutoRebuildConfigEntrySpecified { get; set; }

    }
}
