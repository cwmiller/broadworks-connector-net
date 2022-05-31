using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserCommPilotExpressGetRequest.
    /// <see cref="UserCommPilotExpressGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""8c204d784d1904d9eeea996d46de69be:56""}]")]
    public class UserCommPilotExpressGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.CommPilotExpressProfile _profile;

        [XmlElement(ElementName = "profile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"8c204d784d1904d9eeea996d46de69be:56")]
        public BroadWorksConnector.Ocip.Models.CommPilotExpressProfile Profile
        {
            get => _profile;
            set
            {
                ProfileSpecified = true;
                _profile = value;
            }
        }

        [XmlIgnore]
        protected bool ProfileSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CommPilotExpressAvailableInOffice _availableInOffice;

        [XmlElement(ElementName = "availableInOffice", IsNullable = false, Namespace = "")]
        [Group(@"8c204d784d1904d9eeea996d46de69be:56")]
        public BroadWorksConnector.Ocip.Models.CommPilotExpressAvailableInOffice AvailableInOffice
        {
            get => _availableInOffice;
            set
            {
                AvailableInOfficeSpecified = true;
                _availableInOffice = value;
            }
        }

        [XmlIgnore]
        protected bool AvailableInOfficeSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CommPilotExpressAvailableOutOfOffice _availableOutOfOffice;

        [XmlElement(ElementName = "availableOutOfOffice", IsNullable = false, Namespace = "")]
        [Group(@"8c204d784d1904d9eeea996d46de69be:56")]
        public BroadWorksConnector.Ocip.Models.CommPilotExpressAvailableOutOfOffice AvailableOutOfOffice
        {
            get => _availableOutOfOffice;
            set
            {
                AvailableOutOfOfficeSpecified = true;
                _availableOutOfOffice = value;
            }
        }

        [XmlIgnore]
        protected bool AvailableOutOfOfficeSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CommPilotExpressBusy _busy;

        [XmlElement(ElementName = "busy", IsNullable = false, Namespace = "")]
        [Group(@"8c204d784d1904d9eeea996d46de69be:56")]
        public BroadWorksConnector.Ocip.Models.CommPilotExpressBusy Busy
        {
            get => _busy;
            set
            {
                BusySpecified = true;
                _busy = value;
            }
        }

        [XmlIgnore]
        protected bool BusySpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CommPilotExpressUnavailable _unavailable;

        [XmlElement(ElementName = "unavailable", IsNullable = false, Namespace = "")]
        [Group(@"8c204d784d1904d9eeea996d46de69be:56")]
        public BroadWorksConnector.Ocip.Models.CommPilotExpressUnavailable Unavailable
        {
            get => _unavailable;
            set
            {
                UnavailableSpecified = true;
                _unavailable = value;
            }
        }

        [XmlIgnore]
        protected bool UnavailableSpecified { get; set; }

    }
}
