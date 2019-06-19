using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserEnhancedCallLogsGetListRequest16.
    /// Total numbers of rows is:
    /// - the total number of retrievable logs of the call log type that was specified in the
    /// UserEnhancedCallLogsGetListRequest16,
    /// if a call log type was specified in the request.
    /// - the total number of retrievable logs, if no call log type was specified in the request.
    /// 
    /// Replaced by UserEnhancedCallLogsGetListResponse17sp4
    /// <see cref="UserEnhancedCallLogsGetListRequest16"/>
    /// <see cref="UserEnhancedCallLogsGetListRequest16"/>
    /// <see cref="UserEnhancedCallLogsGetListResponse17sp4"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:23446""}]")]
    public class UserEnhancedCallLogsGetListResponse16 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private int _totalNumberOfRows;

        [XmlElement(ElementName = "totalNumberOfRows", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:23446")]
        public int TotalNumberOfRows
        {
            get => _totalNumberOfRows;
            set
            {
                TotalNumberOfRowsSpecified = true;
                _totalNumberOfRows = value;
            }
        }

        [XmlIgnore]
        public bool TotalNumberOfRowsSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.MixedCallLogsEntry> _callLog = new List<BroadWorksConnector.Ocip.Models.MixedCallLogsEntry>();

        [XmlElement(ElementName = "callLog", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:23446")]
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
        public bool CallLogSpecified { get; set; }

    }
}
