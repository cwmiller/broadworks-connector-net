using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:43434""}]")]
    public class UserEnhancedCallLogsGetListResponse21LegacyEntry
    {

        protected List<BroadWorksConnector.Ocip.Models.MixedCallLogsEntry> _callLog = new List<BroadWorksConnector.Ocip.Models.MixedCallLogsEntry>();

        [XmlElement(ElementName = "callLog", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:43434")]
        public List<BroadWorksConnector.Ocip.Models.MixedCallLogsEntry> CallLog
        {
            get => _callLog;
            set
            {
                CallLogSpecified = true;
                _callLog = value;
            }
        }

        [XmlIgnore]
        protected bool CallLogSpecified { get; set; }

    }
}
