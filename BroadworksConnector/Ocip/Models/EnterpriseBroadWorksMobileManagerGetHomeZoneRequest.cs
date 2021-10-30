using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a home zone from the BroadWorks Mobile Manager.
    /// The response is either EnterpriseBroadWorksMobileManagerGetHomeZoneResponse or ErrorResponse.
    /// <see cref="EnterpriseBroadWorksMobileManagerGetHomeZoneResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""5395c7df0157d44aa22f3351d1a5f3da:274""}]")]
    public class EnterpriseBroadWorksMobileManagerGetHomeZoneRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.EnterpriseBroadWorksMobileManagerGetHomeZoneResponse>
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:274")]
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

        private string _homeZoneId;

        [XmlElement(ElementName = "homeZoneId", IsNullable = false, Namespace = "")]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:274")]
        public string HomeZoneId
        {
            get => _homeZoneId;
            set
            {
                HomeZoneIdSpecified = true;
                _homeZoneId = value;
            }
        }

        [XmlIgnore]
        protected bool HomeZoneIdSpecified { get; set; }

    }
}
