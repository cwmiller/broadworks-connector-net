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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1b5ee40628a3f2b1bcab94a53dec91e7:366""}]")]
    public class UserEnhancedCallLogsGetListResponse23LegacyEntry
    {

        protected List<BroadWorksConnector.Ocip.Models.MixedCallLogsEntry> _callLog = new List<BroadWorksConnector.Ocip.Models.MixedCallLogsEntry>();

        [XmlElement(ElementName = "callLog", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1b5ee40628a3f2b1bcab94a53dec91e7:366")]
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
