using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Verification Translation and Routing parameters
    /// for creating a Verify Translation and Routing request from
    /// parameters.
    /// 
    /// The following data elements are only used in AS data mode and ignored in XS data mode:
    /// contact
    /// diversion
    /// 
    /// The following data elements are only used in XS data mode and ignored in AS data mode:
    /// imsCallType
    /// sipInstance
    /// viaAddress
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:5778""}]")]
    public class VerifyTranslationAndRoutingParameters
    {

        protected BroadWorksConnector.Ocip.Models.VerifyTranslationAndRoutingOrigination _origination;

        [XmlElement(ElementName = "origination", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:5778")]
        public BroadWorksConnector.Ocip.Models.VerifyTranslationAndRoutingOrigination Origination
        {
            get => _origination;
            set
            {
                OriginationSpecified = true;
                _origination = value;
            }
        }

        [XmlIgnore]
        protected bool OriginationSpecified { get; set; }

        protected string _destination;

        [XmlElement(ElementName = "destination", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:5778")]
        [MinLength(1)]
        [MaxLength(500)]
        public string Destination
        {
            get => _destination;
            set
            {
                DestinationSpecified = true;
                _destination = value;
            }
        }

        [XmlIgnore]
        protected bool DestinationSpecified { get; set; }

        protected string _contact;

        [XmlElement(ElementName = "contact", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:5778")]
        [MinLength(1)]
        [MaxLength(256)]
        public string Contact
        {
            get => _contact;
            set
            {
                ContactSpecified = true;
                _contact = value;
            }
        }

        [XmlIgnore]
        protected bool ContactSpecified { get; set; }

        protected string _diversion;

        [XmlElement(ElementName = "diversion", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:5778")]
        [MinLength(1)]
        [MaxLength(256)]
        public string Diversion
        {
            get => _diversion;
            set
            {
                DiversionSpecified = true;
                _diversion = value;
            }
        }

        [XmlIgnore]
        protected bool DiversionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.IMSCallType _imsCallType;

        [XmlElement(ElementName = "imsCallType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:5778")]
        public BroadWorksConnector.Ocip.Models.IMSCallType ImsCallType
        {
            get => _imsCallType;
            set
            {
                ImsCallTypeSpecified = true;
                _imsCallType = value;
            }
        }

        [XmlIgnore]
        protected bool ImsCallTypeSpecified { get; set; }

        protected string _sipInstance;

        [XmlElement(ElementName = "sipInstance", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:5778")]
        [MinLength(1)]
        [MaxLength(161)]
        public string SipInstance
        {
            get => _sipInstance;
            set
            {
                SipInstanceSpecified = true;
                _sipInstance = value;
            }
        }

        [XmlIgnore]
        protected bool SipInstanceSpecified { get; set; }

        protected string _viaAddress;

        [XmlElement(ElementName = "viaAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:5778")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ViaAddress
        {
            get => _viaAddress;
            set
            {
                ViaAddressSpecified = true;
                _viaAddress = value;
            }
        }

        [XmlIgnore]
        protected bool ViaAddressSpecified { get; set; }

    }
}
