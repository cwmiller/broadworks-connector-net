using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserSharedCallAppearanceGetRequest14sp2.
    /// The endpointTable contains columns:
    /// "Device Level", "Device Name", "Device Type", "Line/Port", "SIP Contact".
    /// The "Device Level" column contains one of the AccessDeviceLevel enumerated constants.
        /// <see cref="UserSharedCallAppearanceGetRequest14sp2"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserSharedCallAppearanceGetResponse14sp2 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private bool _alertAllAppearancesForClickToDialCalls;

        [XmlElement(ElementName = "alertAllAppearancesForClickToDialCalls", IsNullable = false, Namespace = "")]
        public bool AlertAllAppearancesForClickToDialCalls {
            get => _alertAllAppearancesForClickToDialCalls;
            set {
                AlertAllAppearancesForClickToDialCallsSpecified = true;
                _alertAllAppearancesForClickToDialCalls = value;
            }
        }

        [XmlIgnore]
        public bool AlertAllAppearancesForClickToDialCallsSpecified { get; set; }
        
        private int _maxAppearances;

        [XmlElement(ElementName = "maxAppearances", IsNullable = false, Namespace = "")]
        public int MaxAppearances {
            get => _maxAppearances;
            set {
                MaxAppearancesSpecified = true;
                _maxAppearances = value;
            }
        }

        [XmlIgnore]
        public bool MaxAppearancesSpecified { get; set; }
        
        private bool _allowSCACallRetrieve;

        [XmlElement(ElementName = "allowSCACallRetrieve", IsNullable = false, Namespace = "")]
        public bool AllowSCACallRetrieve {
            get => _allowSCACallRetrieve;
            set {
                AllowSCACallRetrieveSpecified = true;
                _allowSCACallRetrieve = value;
            }
        }

        [XmlIgnore]
        public bool AllowSCACallRetrieveSpecified { get; set; }
        
        private bool _enableMultipleCallArrangement;

        [XmlElement(ElementName = "enableMultipleCallArrangement", IsNullable = false, Namespace = "")]
        public bool EnableMultipleCallArrangement {
            get => _enableMultipleCallArrangement;
            set {
                EnableMultipleCallArrangementSpecified = true;
                _enableMultipleCallArrangement = value;
            }
        }

        [XmlIgnore]
        public bool EnableMultipleCallArrangementSpecified { get; set; }
        
        private bool _multipleCallArrangementIsActive;

        [XmlElement(ElementName = "multipleCallArrangementIsActive", IsNullable = false, Namespace = "")]
        public bool MultipleCallArrangementIsActive {
            get => _multipleCallArrangementIsActive;
            set {
                MultipleCallArrangementIsActiveSpecified = true;
                _multipleCallArrangementIsActive = value;
            }
        }

        [XmlIgnore]
        public bool MultipleCallArrangementIsActiveSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.C.OCITable _endpointTable;

        [XmlElement(ElementName = "endpointTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable EndpointTable {
            get => _endpointTable;
            set {
                EndpointTableSpecified = true;
                _endpointTable = value;
            }
        }

        [XmlIgnore]
        public bool EndpointTableSpecified { get; set; }
        
        private bool _allowBridgingBetweenLocations;

        [XmlElement(ElementName = "allowBridgingBetweenLocations", IsNullable = false, Namespace = "")]
        public bool AllowBridgingBetweenLocations {
            get => _allowBridgingBetweenLocations;
            set {
                AllowBridgingBetweenLocationsSpecified = true;
                _allowBridgingBetweenLocations = value;
            }
        }

        [XmlIgnore]
        public bool AllowBridgingBetweenLocationsSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SharedCallAppearanceBridgeWarningTone _bridgeWarningTone;

        [XmlElement(ElementName = "bridgeWarningTone", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SharedCallAppearanceBridgeWarningTone BridgeWarningTone {
            get => _bridgeWarningTone;
            set {
                BridgeWarningToneSpecified = true;
                _bridgeWarningTone = value;
            }
        }

        [XmlIgnore]
        public bool BridgeWarningToneSpecified { get; set; }
        
    }
}
