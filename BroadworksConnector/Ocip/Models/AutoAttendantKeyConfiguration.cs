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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:48366""}]")]
    public class AutoAttendantKeyConfiguration
    {

        protected BroadWorksConnector.Ocip.Models.AutoAttendantMenuKey _key;

        [XmlElement(ElementName = "key", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:48366")]
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

        protected BroadWorksConnector.Ocip.Models.AutoAttendantKeyConfigurationEntry _entry;

        [XmlElement(ElementName = "entry", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:48366")]
        public BroadWorksConnector.Ocip.Models.AutoAttendantKeyConfigurationEntry Entry
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
