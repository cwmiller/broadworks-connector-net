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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f0ada2681ca347fa83b464734259b304:730""}]")]
    public class SearchCriteriaExactCallCenterType : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        private BroadWorksConnector.Ocip.Models.CallCenterType _callCenterType;

        [XmlElement(ElementName = "callCenterType", IsNullable = false, Namespace = "")]
        [Group(@"f0ada2681ca347fa83b464734259b304:730")]
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
        public bool CallCenterTypeSpecified { get; set; }

    }
}
