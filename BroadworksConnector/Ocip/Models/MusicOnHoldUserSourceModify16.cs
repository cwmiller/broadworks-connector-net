using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Contains the music on hold user source configuration.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:8264""}]")]
    public class MusicOnHoldUserSourceModify16
    {

        private BroadWorksConnector.Ocip.Models.MusicOnHoldUserMessageSelection _messageSourceSelection;

        [XmlElement(ElementName = "messageSourceSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:8264")]
        public BroadWorksConnector.Ocip.Models.MusicOnHoldUserMessageSelection MessageSourceSelection
        {
            get => _messageSourceSelection;
            set
            {
                MessageSourceSelectionSpecified = true;
                _messageSourceSelection = value;
            }
        }

        [XmlIgnore]
        public bool MessageSourceSelectionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.MusicOnHoldUserSourceModify16CustomSource _customSource;

        [XmlElement(ElementName = "customSource", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:8264")]
        public BroadWorksConnector.Ocip.Models.MusicOnHoldUserSourceModify16CustomSource CustomSource
        {
            get => _customSource;
            set
            {
                CustomSourceSpecified = true;
                _customSource = value;
            }
        }

        [XmlIgnore]
        public bool CustomSourceSpecified { get; set; }

    }
}
