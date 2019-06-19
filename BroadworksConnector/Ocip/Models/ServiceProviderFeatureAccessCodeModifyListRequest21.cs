using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a list of feature access codes for a service provider or enterprise.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// 
    /// In release 20 the "Call Recording" FAC name is changed to
    /// "Call Recording - Start".
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:3523""}]")]
    public class ServiceProviderFeatureAccessCodeModifyListRequest21 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:3523")]
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
        public bool ServiceProviderIdSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.FeatureAccessCodeModifyEntry> _featureAccessCode = new List<BroadWorksConnector.Ocip.Models.FeatureAccessCodeModifyEntry>();

        [XmlElement(ElementName = "featureAccessCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:3523")]
        public List<BroadWorksConnector.Ocip.Models.FeatureAccessCodeModifyEntry> FeatureAccessCode
        {
            get => _featureAccessCode;
            set
            {
                FeatureAccessCodeSpecified = true;
                _featureAccessCode = value;
            }
        }

        [XmlIgnore]
        public bool FeatureAccessCodeSpecified { get; set; }

    }
}
