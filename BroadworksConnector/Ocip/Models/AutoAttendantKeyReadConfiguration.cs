using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The read configuration of a key for Auto Attendant.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:44325""}]")]
    public class AutoAttendantKeyReadConfiguration
    {

        private BroadWorksConnector.Ocip.Models.AutoAttendantMenuKey _key;

        [XmlElement(ElementName = "key", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:44325")]
        public BroadWorksConnector.Ocip.Models.AutoAttendantMenuKey Key
        {
            get => _key;
            set
            {
                KeySpecified = true;
                _key = value;
            }
        }

        [XmlIgnore]
        public bool KeySpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AutoAttendantKeyConfigurationReadEntry _entry;

        [XmlElement(ElementName = "entry", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:44325")]
        public BroadWorksConnector.Ocip.Models.AutoAttendantKeyConfigurationReadEntry Entry
        {
            get => _entry;
            set
            {
                EntrySpecified = true;
                _entry = value;
            }
        }

        [XmlIgnore]
        public bool EntrySpecified { get; set; }

    }
}
