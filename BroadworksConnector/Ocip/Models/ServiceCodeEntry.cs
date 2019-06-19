using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The service code entry.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:18692""}]")]
    public class ServiceCodeEntry
    {

        private string _serviceCode;

        [XmlElement(ElementName = "serviceCode", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:18692")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceCode
        {
            get => _serviceCode;
            set
            {
                ServiceCodeSpecified = true;
                _serviceCode = value;
            }
        }

        [XmlIgnore]
        public bool ServiceCodeSpecified { get; set; }

        private string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:18692")]
        [MinLength(1)]
        [MaxLength(200)]
        public string Description
        {
            get => _description;
            set
            {
                DescriptionSpecified = true;
                _description = value;
            }
        }

        [XmlIgnore]
        public bool DescriptionSpecified { get; set; }

    }
}
