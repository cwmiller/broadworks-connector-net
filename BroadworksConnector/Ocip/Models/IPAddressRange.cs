using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// IP Address Range.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:3434""}]")]
    public class IPAddressRange
    {

        protected string _minIpAddress;

        [XmlElement(ElementName = "minIpAddress", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:3434")]
        [MinLength(1)]
        [MaxLength(39)]
        public string MinIpAddress
        {
            get => _minIpAddress;
            set
            {
                MinIpAddressSpecified = true;
                _minIpAddress = value;
            }
        }

        [XmlIgnore]
        protected bool MinIpAddressSpecified { get; set; }

        protected string _maxIpAddress;

        [XmlElement(ElementName = "maxIpAddress", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:3434")]
        [MinLength(1)]
        [MaxLength(39)]
        public string MaxIpAddress
        {
            get => _maxIpAddress;
            set
            {
                MaxIpAddressSpecified = true;
                _maxIpAddress = value;
            }
        }

        [XmlIgnore]
        protected bool MaxIpAddressSpecified { get; set; }

    }
}
