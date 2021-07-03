using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A SIP Contact info contains the SIP registration Contact and its associated Header path
    /// The following element is only used in AS data mode and ignored in XS data mode:
    /// pathHeader
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:4644""}]")]
    public class SIPContactInfo
    {

        private string _sipContact;

        [XmlElement(ElementName = "sipContact", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4644")]
        [MinLength(1)]
        [MaxLength(1020)]
        public string SipContact
        {
            get => _sipContact;
            set
            {
                SipContactSpecified = true;
                _sipContact = value;
            }
        }

        [XmlIgnore]
        protected bool SipContactSpecified { get; set; }

        private string _pathHeader;

        [XmlElement(ElementName = "pathHeader", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4644")]
        [MinLength(1)]
        [MaxLength(1024)]
        public string PathHeader
        {
            get => _pathHeader;
            set
            {
                PathHeaderSpecified = true;
                _pathHeader = value;
            }
        }

        [XmlIgnore]
        protected bool PathHeaderSpecified { get; set; }

    }
}
