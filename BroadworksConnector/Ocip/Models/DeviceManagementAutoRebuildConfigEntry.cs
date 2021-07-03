using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Contains one automatic rebuild configuration list entry.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:19896""}]")]
    public class DeviceManagementAutoRebuildConfigEntry
    {

        private string _ociRequestPrefix;

        [XmlElement(ElementName = "ociRequestPrefix", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:19896")]
        [MinLength(1)]
        [MaxLength(256)]
        public string OciRequestPrefix
        {
            get => _ociRequestPrefix;
            set
            {
                OciRequestPrefixSpecified = true;
                _ociRequestPrefix = value;
            }
        }

        [XmlIgnore]
        protected bool OciRequestPrefixSpecified { get; set; }

        private bool _autoRebuildEnabled;

        [XmlElement(ElementName = "autoRebuildEnabled", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:19896")]
        public bool AutoRebuildEnabled
        {
            get => _autoRebuildEnabled;
            set
            {
                AutoRebuildEnabledSpecified = true;
                _autoRebuildEnabled = value;
            }
        }

        [XmlIgnore]
        protected bool AutoRebuildEnabledSpecified { get; set; }

    }
}
