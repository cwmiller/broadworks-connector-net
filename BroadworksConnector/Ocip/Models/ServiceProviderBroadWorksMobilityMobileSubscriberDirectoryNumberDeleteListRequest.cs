using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Deletes Mobile Subscriber Directory Numbers from a service provider. It is possible to delete either: a single number,
    /// or a list of numbers.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""9ae9f7d53e566e21347e23e20e2a2a39:560""}]")]
    public class ServiceProviderBroadWorksMobilityMobileSubscriberDirectoryNumberDeleteListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:560")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }

        protected List<string> _mobileSubscriberDirectoryNumber = new List<string>();

        [XmlElement(ElementName = "mobileSubscriberDirectoryNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:560")]
        [MinLength(1)]
        [MaxLength(23)]
        public List<string> MobileSubscriberDirectoryNumber
        {
            get => _mobileSubscriberDirectoryNumber;
            set
            {
                MobileSubscriberDirectoryNumberSpecified = true;
                _mobileSubscriberDirectoryNumber = value;
            }
        }

        [XmlIgnore]
        protected bool MobileSubscriberDirectoryNumberSpecified { get; set; }

    }
}
