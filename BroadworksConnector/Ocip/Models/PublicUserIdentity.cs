using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Public User Identity
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:3526""}]")]
    public class PublicUserIdentity
    {

        private string _sipURI;

        [XmlElement(ElementName = "sipURI", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3526")]
        [MinLength(1)]
        [MaxLength(161)]
        public string SipURI
        {
            get => _sipURI;
            set
            {
                SipURISpecified = true;
                _sipURI = value;
            }
        }

        [XmlIgnore]
        protected bool SipURISpecified { get; set; }

        private string _telURI;

        [XmlElement(ElementName = "telURI", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3526")]
        [MinLength(1)]
        [MaxLength(23)]
        public string TelURI
        {
            get => _telURI;
            set
            {
                TelURISpecified = true;
                _telURI = value;
            }
        }

        [XmlIgnore]
        protected bool TelURISpecified { get; set; }

    }
}
