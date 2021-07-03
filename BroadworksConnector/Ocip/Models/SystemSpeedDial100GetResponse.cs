using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemSpeedDial100GetRequest.
    /// 
    /// Replaced by: SystemSpeedDial100GetResponse17sp1
    /// <see cref="SystemSpeedDial100GetRequest"/>
    /// <see cref="SystemSpeedDial100GetResponse17sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:34958""}]")]
    public class SystemSpeedDial100GetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _prefix;

        [XmlElement(ElementName = "prefix", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34958")]
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

    }
}
