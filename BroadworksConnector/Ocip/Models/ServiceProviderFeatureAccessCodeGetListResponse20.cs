using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the ServiceProviderFeatureAccessCodeGetListRequest20.
    /// In release 20 the "Call Recording" FAC name is changed to
    /// "Call Recording - Start".
    /// Replaced by: ServiceProviderFeatureAccessCodeGetListResponse21
    /// <see cref="ServiceProviderFeatureAccessCodeGetListRequest20"/>
    /// <see cref="ServiceProviderFeatureAccessCodeGetListResponse21"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:19280""}]")]
    public class ServiceProviderFeatureAccessCodeGetListResponse20 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<BroadWorksConnector.Ocip.Models.FeatureAccessCodeEntry> _featureAccessCode = new List<BroadWorksConnector.Ocip.Models.FeatureAccessCodeEntry>();

        [XmlElement(ElementName = "featureAccessCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:19280")]
        public List<BroadWorksConnector.Ocip.Models.FeatureAccessCodeEntry> FeatureAccessCode
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
