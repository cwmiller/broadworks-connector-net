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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:20168""}]")]
    public class DeviceManagementAutoRebuildConfigEntry
    {

        protected string _ociRequestPrefix;

        [XmlElement(ElementName = "ociRequestPrefix", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:20168")]
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

        protected bool _autoRebuildEnabled;

        [XmlElement(ElementName = "autoRebuildEnabled", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:20168")]
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
