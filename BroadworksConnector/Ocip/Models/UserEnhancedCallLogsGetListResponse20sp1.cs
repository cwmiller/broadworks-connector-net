using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserEnhancedCallLogsGetListRequest20sp1.
    /// Total numbers of rows is:
    /// - the total number of retrievable logs of the call log type that was specified in the UserEnhancedCallLogsGetListRequest20sp1,
    /// if a call log type was specified in the request.
    /// - the total number of retrievable logs, if no call log type was specified in the request.
    /// A list of MixedCallLogsEntry will be returned if the call logs are stored on CDS
    /// A list of ExtendedMixedCallLogsEntry20sp1 will be returned if the call logs are stored on DBS
    /// The logs are sorted by date/time of the call.
    /// <see cref="UserEnhancedCallLogsGetListRequest20sp1"/>
    /// <see cref="UserEnhancedCallLogsGetListRequest20sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:43386"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:43388""}]}]")]
    public class UserEnhancedCallLogsGetListResponse20sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected int _totalNumberOfRows;

        [XmlElement(ElementName = "totalNumberOfRows", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:43386")]
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

        protected BroadWorksConnector.Ocip.Models.UserEnhancedCallLogsGetListResponse20sp1LegacyEntry _legacyEntry;

        [XmlElement(ElementName = "legacyEntry", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:43388")]
        public BroadWorksConnector.Ocip.Models.UserEnhancedCallLogsGetListResponse20sp1LegacyEntry LegacyEntry
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

        protected BroadWorksConnector.Ocip.Models.UserEnhancedCallLogsGetListResponse20sp1ExtendedEntry _extendedEntry;

        [XmlElement(ElementName = "extendedEntry", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:43388")]
        public BroadWorksConnector.Ocip.Models.UserEnhancedCallLogsGetListResponse20sp1ExtendedEntry ExtendedEntry
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
