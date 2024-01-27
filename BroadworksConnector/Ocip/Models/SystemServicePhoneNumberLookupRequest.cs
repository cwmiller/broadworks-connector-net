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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:16421""}]")]
    public class SystemServicePhoneNumberLookupRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemServicePhoneNumberLookupResponse>
    {

        protected BroadWorksConnector.Ocip.Models.NumberLookupServiceType _serviceType;

        [XmlElement(ElementName = "serviceType", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:16421")]
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
        protected bool ServiceTypeSpecified { get; set; }

        protected string _phoneNumber;

        [XmlElement(ElementName = "phoneNumber", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:16421")]
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
        protected bool PhoneNumberSpecified { get; set; }

    }
}
