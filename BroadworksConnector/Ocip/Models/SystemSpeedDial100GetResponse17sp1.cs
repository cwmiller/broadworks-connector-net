using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemSpeedDial100GetRequest17sp1.
    /// <see cref="SystemSpeedDial100GetRequest17sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e084de202cf726c3202fca43390f9ec5:111""}]")]
    public class SystemSpeedDial100GetResponse17sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _prefix;

        [XmlElement(ElementName = "prefix", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e084de202cf726c3202fca43390f9ec5:111")]
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
