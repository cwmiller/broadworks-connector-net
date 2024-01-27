using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for a particular fully specified call center type.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""972fbf832439609ec8f2765c5637c3f1:823""}]")]
    public class SearchCriteriaExactCallCenterType : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        protected BroadWorksConnector.Ocip.Models.CallCenterType _callCenterType;

        [XmlElement(ElementName = "callCenterType", IsNullable = false, Namespace = "")]
        [Group(@"972fbf832439609ec8f2765c5637c3f1:823")]
        public BroadWorksConnector.Ocip.Models.CallCenterType CallCenterType
        {
            get => _callCenterType;
            set
            {
                CallCenterTypeSpecified = true;
                _callCenterType = value;
            }
        }

        [XmlIgnore]
        protected bool CallCenterTypeSpecified { get; set; }

    }
}
