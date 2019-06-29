using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// This is the configuration parameters for Speed Dial 8 service
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:4385""}]")]
    public class ProfileAndServiceSpeedDial8Info
    {

        private List<BroadWorksConnector.Ocip.Models.SpeedDial8Entry> _speedDialEntry = new List<BroadWorksConnector.Ocip.Models.SpeedDial8Entry>();

        [XmlElement(ElementName = "speedDialEntry", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:4385")]
        public List<BroadWorksConnector.Ocip.Models.SpeedDial8Entry> SpeedDialEntry
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
