using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Represents either a random port number, or a specific port number.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:2968""}]")]
    public class RandomPort
    {

        private string _random;

        [XmlElement(ElementName = "random", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2968")]
        public string Random
        {
            get => _random;
            set
            {
                RandomSpecified = true;
                _random = value;
            }
        }

        [XmlIgnore]
        public bool RandomSpecified { get; set; }

        private int _port;

        [XmlElement(ElementName = "port", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2968")]
        [MinInclusive(1)]
        [MaxInclusive(65535)]
        public int Port
        {
            get => _port;
            set
            {
                PortSpecified = true;
                _port = value;
            }
        }

        [XmlIgnore]
        public bool PortSpecified { get; set; }

    }
}
