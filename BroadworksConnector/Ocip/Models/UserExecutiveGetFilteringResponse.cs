using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserExecutiveGetFilteringRequest.
    /// Contains the filtering setting and a table of filtering criteria.
    /// The criteria table's column headings are: "Is Active", "Criteria Name", "Time Schedule", "Calls From",
    /// "Filter", "Holiday Schedule", "Calls To Type", "Calls To Number" and "Calls To Extension".
    /// The "Filter" column can contain "true" or "false".
    /// The possible values for the "Calls To Type" column are the following or a combination of them separated by comma:
    /// - Primary
    /// - Alternate X (where x is a number between 1 and 10)
    /// - Mobility
    /// The possible values for the "Calls To Number" column are the following or a combination of them separated by comma:
    /// - The value of the phone number for the corresponding Calls To Type, when the number is available. i.e. Alternate 1 may have extension, but no number.
    /// - When no number is available a blank space is provided instead.
    /// The possible values for the "Calls To Extension" column are the following or a combination of them separated by comma:
    /// - The value of the extension for the corresponding Calls To Type, when the extension is available. i.e. Primary may have number, but no extension.
    /// - For Mobility Calls To Type, this is always blank.
    /// - When no extension is available a blank space is provided instead.
        /// <see cref="UserExecutiveGetFilteringRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserExecutiveGetFilteringResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private bool _enableFiltering;

        [XmlElement(ElementName = "enableFiltering", IsNullable = false, Namespace = "")]
        public bool EnableFiltering {
            get => _enableFiltering;
            set {
                EnableFilteringSpecified = true;
                _enableFiltering = value;
            }
        }

        [XmlIgnore]
        public bool EnableFilteringSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ExecutiveCallFilteringMode _filteringMode;

        [XmlElement(ElementName = "filteringMode", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ExecutiveCallFilteringMode FilteringMode {
            get => _filteringMode;
            set {
                FilteringModeSpecified = true;
                _filteringMode = value;
            }
        }

        [XmlIgnore]
        public bool FilteringModeSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ExecutiveCallFilteringSimpleFilterType _simpleFilterType;

        [XmlElement(ElementName = "simpleFilterType", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ExecutiveCallFilteringSimpleFilterType SimpleFilterType {
            get => _simpleFilterType;
            set {
                SimpleFilterTypeSpecified = true;
                _simpleFilterType = value;
            }
        }

        [XmlIgnore]
        public bool SimpleFilterTypeSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.C.OCITable _criteriaTable;

        [XmlElement(ElementName = "criteriaTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable CriteriaTable {
            get => _criteriaTable;
            set {
                CriteriaTableSpecified = true;
                _criteriaTable = value;
            }
        }

        [XmlIgnore]
        public bool CriteriaTableSpecified { get; set; }
        
    }
}
