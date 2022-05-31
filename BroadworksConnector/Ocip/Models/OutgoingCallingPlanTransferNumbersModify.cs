using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Outgoing Calling Plan transfer numbers.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6f793dfca9bd3d121bb35e0f9cf1cb2e:2221""}]")]
    public class OutgoingCallingPlanTransferNumbersModify
    {

        protected string _phoneNumber01;

        [XmlElement(ElementName = "phoneNumber01", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:2221")]
        [MinLength(1)]
        [MaxLength(30)]
        public string PhoneNumber01
        {
            get => _phoneNumber01;
            set
            {
                PhoneNumber01Specified = true;
                _phoneNumber01 = value;
            }
        }

        [XmlIgnore]
        protected bool PhoneNumber01Specified { get; set; }

        protected string _phoneNumber02;

        [XmlElement(ElementName = "phoneNumber02", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:2221")]
        [MinLength(1)]
        [MaxLength(30)]
        public string PhoneNumber02
        {
            get => _phoneNumber02;
            set
            {
                PhoneNumber02Specified = true;
                _phoneNumber02 = value;
            }
        }

        [XmlIgnore]
        protected bool PhoneNumber02Specified { get; set; }

        protected string _phoneNumber03;

        [XmlElement(ElementName = "phoneNumber03", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:2221")]
        [MinLength(1)]
        [MaxLength(30)]
        public string PhoneNumber03
        {
            get => _phoneNumber03;
            set
            {
                PhoneNumber03Specified = true;
                _phoneNumber03 = value;
            }
        }

        [XmlIgnore]
        protected bool PhoneNumber03Specified { get; set; }

    }
}
