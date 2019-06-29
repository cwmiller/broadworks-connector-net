using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserSharedCallAppearanceGetRequest14.
    /// The endpointTable contains columns:
    /// "Device Level", "Device Name", "Device Type", "Line/Port", "SIP Contact".
    /// The "Device Level" column contains one of the AccessDeviceLevel enumerated constants.
    /// Replaced By: UserSharedCallAppearanceGetResponse14sp2
    /// <see cref="UserSharedCallAppearanceGetRequest14"/>
    /// <see cref="UserSharedCallAppearanceGetResponse14sp2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:7674""}]")]
    public class UserSharedCallAppearanceGetResponse14 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _alertAllAppearancesForClickToDialCalls;

        [XmlElement(ElementName = "alertAllAppearancesForClickToDialCalls", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:7674")]
        public bool AlertAllAppearancesForClickToDialCalls
        {
            get => _alertAllAppearancesForClickToDialCalls;
            set
            {
                AlertAllAppearancesForClickToDialCallsSpecified = true;
                _alertAllAppearancesForClickToDialCalls = value;
            }
        }

        [XmlIgnore]
        protected bool AlertAllAppearancesForClickToDialCallsSpecified { get; set; }

        private int _maxAppearances;

        [XmlElement(ElementName = "maxAppearances", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:7674")]
        public int MaxAppearances
        {
            get => _maxAppearances;
            set
            {
                MaxAppearancesSpecified = true;
                _maxAppearances = value;
            }
        }

        [XmlIgnore]
        protected bool MaxAppearancesSpecified { get; set; }

        private bool _enableMultipleCallArrangement;

        [XmlElement(ElementName = "enableMultipleCallArrangement", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:7674")]
        public bool EnableMultipleCallArrangement
        {
            get => _enableMultipleCallArrangement;
            set
            {
                EnableMultipleCallArrangementSpecified = true;
                _enableMultipleCallArrangement = value;
            }
        }

        [XmlIgnore]
        protected bool EnableMultipleCallArrangementSpecified { get; set; }

        private bool _multipleCallArrangementIsActive;

        [XmlElement(ElementName = "multipleCallArrangementIsActive", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:7674")]
        public bool MultipleCallArrangementIsActive
        {
            get => _multipleCallArrangementIsActive;
            set
            {
                MultipleCallArrangementIsActiveSpecified = true;
                _multipleCallArrangementIsActive = value;
            }
        }

        [XmlIgnore]
        protected bool MultipleCallArrangementIsActiveSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.C.OCITable _endpointTable;

        [XmlElement(ElementName = "endpointTable", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:7674")]
        public BroadWorksConnector.Ocip.Models.C.OCITable EndpointTable
        {
            get => _endpointTable;
            set
            {
                EndpointTableSpecified = true;
                _endpointTable = value;
            }
        }

        [XmlIgnore]
        protected bool EndpointTableSpecified { get; set; }

        private bool _allowBridgingBetweenLocations;

        [XmlElement(ElementName = "allowBridgingBetweenLocations", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:7674")]
        public bool AllowBridgingBetweenLocations
        {
            get => _allowBridgingBetweenLocations;
            set
            {
                AllowBridgingBetweenLocationsSpecified = true;
                _allowBridgingBetweenLocations = value;
            }
        }

        [XmlIgnore]
        protected bool AllowBridgingBetweenLocationsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SharedCallAppearanceBridgeWarningTone _bridgeWarningTone;

        [XmlElement(ElementName = "bridgeWarningTone", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:7674")]
        public BroadWorksConnector.Ocip.Models.SharedCallAppearanceBridgeWarningTone BridgeWarningTone
        {
            get => _bridgeWarningTone;
            set
            {
                BridgeWarningToneSpecified = true;
                _bridgeWarningTone = value;
            }
        }

        [XmlIgnore]
        protected bool BridgeWarningToneSpecified { get; set; }

    }
}
