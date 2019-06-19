using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemFeatureAccessCodeGetListRequest21.
    /// 
    /// In release 20 the "Call Recording" FAC name is changed to
    /// "Call Recording - Start".
    /// <see cref="SystemFeatureAccessCodeGetListRequest21"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:9154""}]")]
    public class SystemFeatureAccessCodeGetListResponse21 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<BroadWorksConnector.Ocip.Models.FeatureAccessCodeReadEntry> _featureAccessCode = new List<BroadWorksConnector.Ocip.Models.FeatureAccessCodeReadEntry>();

        [XmlElement(ElementName = "featureAccessCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:9154")]
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
        public bool FeatureAccessCodeSpecified { get; set; }

    }
}
