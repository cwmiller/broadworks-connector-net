using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// This is the configuration parameters for Speed Dial 100 service
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:4557""}]")]
    public class ProfileAndServiceSpeedDial100Info
    {

        private string _prefix;

        [XmlElement(ElementName = "prefix", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:4557")]
        [MinLength(1)]
        [MaxLength(2)]
        public string Prefix
        {
            get => _prefix;
            set
            {
                PrefixSpecified = true;
                _prefix = value;
            }
        }

        [XmlIgnore]
        protected bool PrefixSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SpeedDial100Entry> _speedDialEntry = new List<BroadWorksConnector.Ocip.Models.SpeedDial100Entry>();

        [XmlElement(ElementName = "speedDialEntry", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:4557")]
        public List<BroadWorksConnector.Ocip.Models.SpeedDial100Entry> SpeedDialEntry
        {
            get => _speedDialEntry;
            set
            {
                SpeedDialEntrySpecified = true;
                _speedDialEntry = value;
            }
        }

        [XmlIgnore]
        protected bool SpeedDialEntrySpecified { get; set; }

    }
}
