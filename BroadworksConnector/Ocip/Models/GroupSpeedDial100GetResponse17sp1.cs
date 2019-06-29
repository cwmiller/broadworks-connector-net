using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupSpeedDial100GetRequest17sp1.
    /// <see cref="GroupSpeedDial100GetRequest17sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""066a3d16bce438447d23cbe6ff0885a6:64""}]")]
    public class GroupSpeedDial100GetResponse17sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _prefix;

        [XmlElement(ElementName = "prefix", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"066a3d16bce438447d23cbe6ff0885a6:64")]
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
