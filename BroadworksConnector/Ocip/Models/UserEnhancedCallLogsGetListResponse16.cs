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
    /// - the total number of retrievable logs of the call log type that was specified in the UserEnhancedCallLogsGetListRequest16,
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:43241""}]")]
    public class UserEnhancedCallLogsGetListResponse16 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected int _totalNumberOfRows;

        [XmlElement(ElementName = "totalNumberOfRows", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:43241")]
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
        protected bool TotalNumberOfRowsSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.MixedCallLogsEntry> _callLog = new List<BroadWorksConnector.Ocip.Models.MixedCallLogsEntry>();

        [XmlElement(ElementName = "callLog", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:43241")]
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
