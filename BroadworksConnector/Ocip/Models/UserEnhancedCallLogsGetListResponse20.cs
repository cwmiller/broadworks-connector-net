using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserEnhancedCallLogsGetListRequest20.
    /// Total numbers of rows is:
    /// - the total number of retrievable logs of the call log type that was specified in the
    /// UserEnhancedCallLogsGetListRequest20,
    /// if a call log type was specified in the request.
    /// - the total number of retrievable logs, if no call log type was specified in the request.
    /// A list of MixedCallLogsEntry will be returned if the call logs are stored on CDS
    /// A list of ExtendedMixedCallLogsEntry20 will be returned if the call logs are stored on DBS
    /// The logs are sorted by date/time of the call.
    /// <see cref="UserEnhancedCallLogsGetListRequest20"/>
    /// <see cref="UserEnhancedCallLogsGetListRequest20"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:35785"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:35787""}]}]")]
    public class UserEnhancedCallLogsGetListResponse20 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private int _totalNumberOfRows;

        [XmlElement(ElementName = "totalNumberOfRows", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35785")]
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

        private BroadWorksConnector.Ocip.Models.UserEnhancedCallLogsGetListResponse20LegacyEntry _legacyEntry;

        [XmlElement(ElementName = "legacyEntry", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35787")]
        public BroadWorksConnector.Ocip.Models.UserEnhancedCallLogsGetListResponse20LegacyEntry LegacyEntry
        {
            get => _legacyEntry;
            set
            {
                LegacyEntrySpecified = true;
                _legacyEntry = value;
            }
        }

        [XmlIgnore]
        public bool LegacyEntrySpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.UserEnhancedCallLogsGetListResponse20ExtendedEntry _extendedEntry;

        [XmlElement(ElementName = "extendedEntry", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35787")]
        public BroadWorksConnector.Ocip.Models.UserEnhancedCallLogsGetListResponse20ExtendedEntry ExtendedEntry
        {
            get => _extendedEntry;
            set
            {
                ExtendedEntrySpecified = true;
                _extendedEntry = value;
            }
        }

        [XmlIgnore]
        public bool ExtendedEntrySpecified { get; set; }

    }
}
