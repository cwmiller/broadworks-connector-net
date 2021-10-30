using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request a list of available Mobile Subscriber Directory Numbers not yet assigned to any user.
    /// The response is either EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailableListResponse or ErrorResponse.
    /// Replaced by: EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailableListRequest22
    /// <see cref="EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailableListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailableListRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:1985""}]")]
    public class EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailableListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailableListResponse>
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:1985")]
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

    }
}
