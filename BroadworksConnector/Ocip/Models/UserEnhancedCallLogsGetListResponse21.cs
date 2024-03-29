using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserEnhancedCallLogsGetListRequest21.
    /// Total numbers of rows is:
    /// - the total number of retrievable logs of the call log type that was specified in the UserEnhancedCallLogsGetListRequest21,
    /// if a call log type was specified in the request.
    /// - the total number of retrievable logs, if no call log type was specified in the request.
    /// A list of MixedCallLogsEntry will be returned if the call logs are stored on CDS
    /// A list of ExtendedMixedCallLogsEntry21 will be returned if the call logs are stored on DBS
    /// The logs are sorted by date/time of the call.
    /// 
    /// Replaced by: UserEnhancedCallLogsGetListResponse21Sp1 in AS data mode
    /// <see cref="UserEnhancedCallLogsGetListRequest21"/>
    /// <see cref="UserEnhancedCallLogsGetListRequest21"/>
    /// <see cref="UserEnhancedCallLogsGetListResponse21Sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:43428"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:43430""}]}]")]
    public class UserEnhancedCallLogsGetListResponse21 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected int _totalNumberOfRows;

        [XmlElement(ElementName = "totalNumberOfRows", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:43428")]
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

        protected BroadWorksConnector.Ocip.Models.UserEnhancedCallLogsGetListResponse21LegacyEntry _legacyEntry;

        [XmlElement(ElementName = "legacyEntry", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:43430")]
        public BroadWorksConnector.Ocip.Models.UserEnhancedCallLogsGetListResponse21LegacyEntry LegacyEntry
        {
            get => _legacyEntry;
            set
            {
                LegacyEntrySpecified = true;
                _legacyEntry = value;
            }
        }

        [XmlIgnore]
        protected bool LegacyEntrySpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.UserEnhancedCallLogsGetListResponse21ExtendedEntry _extendedEntry;

        [XmlElement(ElementName = "extendedEntry", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:43430")]
        public BroadWorksConnector.Ocip.Models.UserEnhancedCallLogsGetListResponse21ExtendedEntry ExtendedEntry
        {
            get => _extendedEntry;
            set
            {
                ExtendedEntrySpecified = true;
                _extendedEntry = value;
            }
        }

        [XmlIgnore]
        protected bool ExtendedEntrySpecified { get; set; }

    }
}
