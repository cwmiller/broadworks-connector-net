using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserSpeedDial100GetRequest.
    /// <see cref="UserSpeedDial100GetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""066a3d16bce438447d23cbe6ff0885a6:225""}]")]
    public class UserSpeedDial100GetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _phoneNumber;

        [XmlElement(ElementName = "phoneNumber", IsNullable = false, Namespace = "")]
        [Group(@"066a3d16bce438447d23cbe6ff0885a6:225")]
        [MinLength(1)]
        [MaxLength(161)]
        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                PhoneNumberSpecified = true;
                _phoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool PhoneNumberSpecified { get; set; }

        private string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"066a3d16bce438447d23cbe6ff0885a6:225")]
        [MinLength(1)]
        [MaxLength(80)]
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
