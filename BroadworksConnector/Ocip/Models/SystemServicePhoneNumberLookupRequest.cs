using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Lookup if the given number is defined in the specified service in the system.
    /// The response is SystemServicePhoneNumberLookupResponse.
    /// <see cref="SystemServicePhoneNumberLookupResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:15063""}]")]
    public class SystemServicePhoneNumberLookupRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private BroadWorksConnector.Ocip.Models.NumberLookupServiceType _serviceType;

        [XmlElement(ElementName = "serviceType", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15063")]
        public BroadWorksConnector.Ocip.Models.NumberLookupServiceType ServiceType
        {
            get => _serviceType;
            set
            {
                ServiceTypeSpecified = true;
                _serviceType = value;
            }
        }

        [XmlIgnore]
        public bool ServiceTypeSpecified { get; set; }

        private string _phoneNumber;

        [XmlElement(ElementName = "phoneNumber", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15063")]
        [MinLength(1)]
        [MaxLength(23)]
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

    }
}
