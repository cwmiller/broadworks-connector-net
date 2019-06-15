using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserEnhancedCallLogsGetListRequest17sp4.
    /// Total numbers of rows is:
    /// - the total number of retrievable logs of the call log type that was specified in the
    /// UserEnhancedCallLogsGetListRequest17sp4,
    /// if a call log type was specified in the request.
    /// - the total number of retrievable logs, if no call log type was specified in the request.
    /// A list of MixedCallLogsEntry will be returned if the call logs are stored on CDS
    /// A list of ExtendedMixedCallLogsEntry will be returned if the call logs are stored on DBS
    /// The logs are sorted by date/time of the call.
    /// Replaced by UserEnhancedCallLogsGetListResponse17sp4V2.
    /// Originally deprecated in release 20.
        /// <see cref="UserEnhancedCallLogsGetListRequest17sp4"/>
        /// <see cref="UserEnhancedCallLogsGetListRequest17sp4"/>
        /// <see cref="UserEnhancedCallLogsGetListResponse17sp4V2"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserEnhancedCallLogsGetListResponse17sp4 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private int _totalNumberOfRows;

        [XmlElement(ElementName = "totalNumberOfRows", IsNullable = false, Namespace = "")]
        public int TotalNumberOfRows {
            get => _totalNumberOfRows;
            set {
                TotalNumberOfRowsSpecified = true;
                _totalNumberOfRows = value;
            }
        }

        [XmlIgnore]
        public bool TotalNumberOfRowsSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.UserEnhancedCallLogsGetListResponse17sp4LegacyEntry _legacyEntry;

        [XmlElement(ElementName = "legacyEntry", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.UserEnhancedCallLogsGetListResponse17sp4LegacyEntry LegacyEntry {
            get => _legacyEntry;
            set {
                LegacyEntrySpecified = true;
                _legacyEntry = value;
            }
        }

        [XmlIgnore]
        public bool LegacyEntrySpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.UserEnhancedCallLogsGetListResponse17sp4ExtendedEntry _extendedEntry;

        [XmlElement(ElementName = "extendedEntry", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.UserEnhancedCallLogsGetListResponse17sp4ExtendedEntry ExtendedEntry {
            get => _extendedEntry;
            set {
                ExtendedEntrySpecified = true;
                _extendedEntry = value;
            }
        }

        [XmlIgnore]
        public bool ExtendedEntrySpecified { get; set; }
        
    }
}
