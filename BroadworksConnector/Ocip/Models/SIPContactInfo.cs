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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:5109""}]")]
    public class SIPContactInfo
    {

        protected string _sipContact;

        [XmlElement(ElementName = "sipContact", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:5109")]
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

        protected string _pathHeader;

        [XmlElement(ElementName = "pathHeader", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:5109")]
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
