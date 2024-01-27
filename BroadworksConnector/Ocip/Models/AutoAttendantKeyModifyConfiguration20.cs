using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The modify configuration of a key for Auto Attendant.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:835""}]")]
    public class AutoAttendantKeyModifyConfiguration20
    {

        protected BroadWorksConnector.Ocip.Models.AutoAttendantMenuKey _key;

        [XmlElement(ElementName = "key", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:835")]
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
        protected bool KeySpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AutoAttendantKeyConfigurationModifyEntry20 _entry;

        [XmlElement(ElementName = "entry", IsNullable = true, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:835")]
        public BroadWorksConnector.Ocip.Models.AutoAttendantKeyConfigurationModifyEntry20 Entry
        {
            get => _entry;
            set
            {
                EntrySpecified = true;
                _entry = value;
            }
        }

        [XmlIgnore]
        protected bool EntrySpecified { get; set; }

    }
}
