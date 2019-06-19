using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The configuration of a key for Auto Attendant.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:575""}]")]
    public class AutoAttendantKeyConfiguration20
    {

        private BroadWorksConnector.Ocip.Models.AutoAttendantMenuKey _key;

        [XmlElement(ElementName = "key", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:575")]
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

        private BroadWorksConnector.Ocip.Models.AutoAttendantKeyConfigurationEntry20 _entry;

        [XmlElement(ElementName = "entry", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:575")]
        public BroadWorksConnector.Ocip.Models.AutoAttendantKeyConfigurationEntry20 Entry
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
