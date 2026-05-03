using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Contains the music on hold user source configuration.
    /// The following elements are only used in AS data mode and not returned in XS data mode:
    /// urlSource
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3a0309eb8d406fefc891f554ef114669:430""}]")]
    public class MusicOnHoldUserSourceReadRI
    {

        protected BroadWorksConnector.Ocip.Models.MusicOnHoldUserMessageSelectionRI _messageSourceSelection;

        [XmlElement(ElementName = "messageSourceSelection", IsNullable = false, Namespace = "")]
        [Group(@"3a0309eb8d406fefc891f554ef114669:430")]
        public BroadWorksConnector.Ocip.Models.MusicOnHoldUserMessageSelectionRI MessageSourceSelection
        {
            get => _messageSourceSelection;
            set
            {
                MessageSourceSelectionSpecified = true;
                _messageSourceSelection = value;
            }
        }

        [XmlIgnore]
        protected bool MessageSourceSelectionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.MusicOnHoldUserSourceReadRICustomSource _customSource;

        [XmlElement(ElementName = "customSource", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3a0309eb8d406fefc891f554ef114669:430")]
        public BroadWorksConnector.Ocip.Models.MusicOnHoldUserSourceReadRICustomSource CustomSource
        {
            get => _customSource;
            set
            {
                CustomSourceSpecified = (value != null);
                _customSource = value;
            }
        }

        [XmlIgnore]
        protected bool CustomSourceSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.MusicOnHoldUserSourceReadRIUrlSource _urlSource;

        [XmlElement(ElementName = "urlSource", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3a0309eb8d406fefc891f554ef114669:430")]
        public BroadWorksConnector.Ocip.Models.MusicOnHoldUserSourceReadRIUrlSource UrlSource
        {
            get => _urlSource;
            set
            {
                UrlSourceSpecified = (value != null);
                _urlSource = value;
            }
        }

        [XmlIgnore]
        protected bool UrlSourceSpecified { get; set; }

    }
}
