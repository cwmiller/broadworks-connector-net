using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Extension range. The minimum and maximum values are inclusive.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:49834""}]")]
    public class ExtensionRange
    {

        protected string _minExtension;

        [XmlElement(ElementName = "minExtension", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:49834")]
        [MinLength(2)]
        [MaxLength(6)]
        public string MinExtension
        {
            get => _minExtension;
            set
            {
                MinExtensionSpecified = true;
                _minExtension = value;
            }
        }

        [XmlIgnore]
        protected bool MinExtensionSpecified { get; set; }

        protected string _maxExtension;

        [XmlElement(ElementName = "maxExtension", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:49834")]
        [MinLength(2)]
        [MaxLength(6)]
        public string MaxExtension
        {
            get => _maxExtension;
            set
            {
                MaxExtensionSpecified = true;
                _maxExtension = value;
            }
        }

        [XmlIgnore]
        protected bool MaxExtensionSpecified { get; set; }

    }
}
