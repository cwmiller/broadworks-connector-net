using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the ServiceProviderFeatureAccessCodeGetListRequest21.
    /// 
    /// In release 20 the "Call Recording" FAC name is changed to
    /// "Call Recording - Start".
    /// <see cref="ServiceProviderFeatureAccessCodeGetListRequest21"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:4214""}]")]
    public class ServiceProviderFeatureAccessCodeGetListResponse21 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<BroadWorksConnector.Ocip.Models.FeatureAccessCodeReadEntry> _featureAccessCode = new List<BroadWorksConnector.Ocip.Models.FeatureAccessCodeReadEntry>();

        [XmlElement(ElementName = "featureAccessCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4214")]
        public List<BroadWorksConnector.Ocip.Models.FeatureAccessCodeReadEntry> FeatureAccessCode
        {
            get => _featureAccessCode;
            set
            {
                FeatureAccessCodeSpecified = true;
                _featureAccessCode = value;
            }
        }

        [XmlIgnore]
        protected bool FeatureAccessCodeSpecified { get; set; }

    }
}
