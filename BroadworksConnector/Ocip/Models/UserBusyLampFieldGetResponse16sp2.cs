using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserBusyLampFieldGetRequest16sp2.
    /// The table has column headings:
    /// "User Id", "Last Name", "First Name", "Hiragana Last Name", "Hiragana First Name",
    /// "Phone Number", "Extension", "Department", "Email Address", "IMP Id",
    /// "User External Id", and "User Place Type".
    /// The possible values for "User Place Type" are: User, Place.
    /// <see cref="UserBusyLampFieldGetRequest16sp2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b1745b5f688013b73224574a66f4f4b2:192""}]")]
    public class UserBusyLampFieldGetResponse16sp2 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _listURI;

        [XmlElement(ElementName = "listURI", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b1745b5f688013b73224574a66f4f4b2:192")]
        [MinLength(1)]
        [MaxLength(161)]
        public string ListURI
        {
            get => _listURI;
            set
            {
                ListURISpecified = true;
                _listURI = value;
            }
        }

        [XmlIgnore]
        protected bool ListURISpecified { get; set; }

        protected bool _enableCallParkNotification;

        [XmlElement(ElementName = "enableCallParkNotification", IsNullable = false, Namespace = "")]
        [Group(@"b1745b5f688013b73224574a66f4f4b2:192")]
        public bool EnableCallParkNotification
        {
            get => _enableCallParkNotification;
            set
            {
                EnableCallParkNotificationSpecified = true;
                _enableCallParkNotification = value;
            }
        }

        [XmlIgnore]
        protected bool EnableCallParkNotificationSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.C.OCITable _monitoredUserTable;

        [XmlElement(ElementName = "monitoredUserTable", IsNullable = false, Namespace = "")]
        [Group(@"b1745b5f688013b73224574a66f4f4b2:192")]
        public BroadWorksConnector.Ocip.Models.C.OCITable MonitoredUserTable
        {
            get => _monitoredUserTable;
            set
            {
                MonitoredUserTableSpecified = true;
                _monitoredUserTable = value;
            }
        }

        [XmlIgnore]
        protected bool MonitoredUserTableSpecified { get; set; }

    }
}
